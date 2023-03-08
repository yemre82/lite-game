using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VectorGraphics;
using TMPro;

public class BlockController : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text[] texts;

    public SVGImage confirmButton;
    public Sprite confirmable;
    public Sprite notConfirmable;

    // Start is called before the first frame update
    void Start()
    {
        RefreshBlocks();
    }

    public void RefreshBlocks()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].text = "";
        }
    } 

    // Update is called once per frame
    void Update()
    {
        if (inputField.text.Length <= 6)
        {
            for(int i = 0; i < texts.Length; i++)
            {
                if (i < inputField.text.Length)
                {
                    texts[i].text = inputField.text[i].ToString();
                }
                else
                {
                    texts[i].text = "";
                }
                
            }
        }
        if (inputField.characterLimit == inputField.text.Length)
        {
            confirmButton.sprite = confirmable;
        }
        else
        {
            confirmButton.sprite = notConfirmable;
        }
    }
}
