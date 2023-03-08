using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float remainigTime;
    public TMP_Text text;
    public TMP_Text sendAgainText;
    public Button sendAgainButton;
    // Start is called before the first frame update
    void Start()
    {
        remainigTime = 100;
        sendAgainText.color = new Color(0.7490196f, 0.7490196f, 0.7490196f, 1);
        sendAgainButton.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        remainigTime -= Time.deltaTime;
        if (remainigTime <= 0)
        {
            remainigTime = 0;
            sendAgainText.color = new Color(0.07450981f, 0.07450981f, 0.07450981f, 1);
            sendAgainButton.interactable = true;
        }
        string minute = ((int)remainigTime / 60).ToString();
        string second = "";
        if (((int)remainigTime % 60) < 10)
        {
            second = "0"+((int)remainigTime % 60).ToString();
        }
        else
        {
            second = ((int)remainigTime % 60).ToString();
        }
        


        text.text = minute + ":" + second;
    }
}
