using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.Networking;

public class ServerManager : NetworkManager
{
    #region Singleton
    public static ServerManager Instance = null;
    #endregion

    private bool offlineSetted = false;
    public bool OfflineSetted
    {
        get { return offlineSetted; }
        set { offlineSetted = value; }
    }

   // private NetworkManager manager;

    public override void Start()
    {
        Instance = this;
       // manager = GameObject.Find("NetworkManager").GetComponent<NetworkManager>();
    }

    public void ConnectToServer()
    {
        StartClient();
    }


    public void DisconnectFromServer()
    {
        Debug.Log("Disconencting Client from Server...");
        StopClient();
    }

    public override void OnClientDisconnect()
    {
        Debug.Log("On Disconenct Client from Server Callback triggered...");
        TrySetOffline();
        
    }

    public override void OnApplicationQuit()
    {
        TrySetOffline();
    }

    public void TrySetOffline()
    {
        if (!offlineSetted)
        {
            StartCoroutine(SetOffline());
            offlineSetted = true;
        }
      
    }


    IEnumerator SetOffline()
    {
        string url = ServerDataManager.URL_setOnline;
        Debug.Log(url);

        WWWForm form = new WWWForm();
        form.AddField("bOnline", 0);
        form.AddField("UID", PlayerData.UID);
        using UnityWebRequest webreq = UnityWebRequest.Post(url, form);
        yield return webreq.SendWebRequest();
        switch (webreq.result)
        {
            case UnityWebRequest.Result.Success:
                Debug.Log(webreq.downloadHandler.text);
                LogOutOfGame();
                break;
            case UnityWebRequest.Result.ProtocolError:
                Debug.LogError(webreq.downloadHandler.text);
                break;
            default:
                Debug.LogError("Server error");
                break;
        }
    }

    private void LogOutOfGame()
    {
        SceneManager.Instance.LoadScene(SCENE_ID.LOGIN);
        PlayerData.ResetData();
    }
}
