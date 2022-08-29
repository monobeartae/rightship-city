using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatBubbleUI : MonoBehaviour
{
    [SerializeField]
    private Text MessageText;

    private float timer = 5.0f;

    public void Init(string message)
    {
        MessageText.text = message;



        float text_height = MessageText.preferredHeight;
        Debug.Log("Text Height: " + text_height);
        RectTransform rt = GetComponent(typeof(RectTransform)) as RectTransform;
        rt.sizeDelta = new Vector2(rt.rect.width, text_height);
    }

    public float GetTimer()
    {
        return timer;
    }

    public void UpdateTimer()
    {
        timer -= Time.deltaTime;
    }
}

