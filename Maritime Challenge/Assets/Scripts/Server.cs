using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Server : Mirror.Examples.MultipleAdditiveScenes.MultiSceneNetManager
{

    private List<Player> onlinePlayers = new List<Player>();

    public override void Start()
    {
        StartServer();
    }

}
