using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VectorGraphics;
using TMPro;

public class ChangeCombineButton : MonoBehaviour
{
    public SVGImage CombineButton;
    public Sprite activatingSprite;
    public Sprite inActivatingSprite;
    public RectTransform buttonTransform;
    public TMP_Text textInside;
    public string text;
    public GameObject UseButton;
    public Sprite useButtonActive;
    public Sprite useButtonInActive;
    public bool is_activate = false;
    public int count = 0;
    public bool is_use = false;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            if (is_activate)
            {
                CombineButton.sprite = activatingSprite;
                textInside.text = "";
                buttonTransform.anchoredPosition = new Vector3(0, -422, 0);
                UseButton.SetActive(true);
                if (!is_use)
                {
                    UseButton.GetComponent<SVGImage>().sprite = useButtonActive;
                }
                else
                {
                    UseButton.GetComponent<SVGImage>().sprite = useButtonInActive;
                }
                
            }
            else
            {
                CombineButton.sprite = inActivatingSprite;
                textInside.text = text;
                buttonTransform.anchoredPosition = new Vector3(0, -422, 0);
                UseButton.SetActive(true);
                if (!is_use)
                {
                    UseButton.GetComponent<SVGImage>().sprite = useButtonActive;
                }
                else
                {
                    UseButton.GetComponent<SVGImage>().sprite = useButtonInActive;
                }
            }

        }
        else
        {
            if (is_activate)
            {
                CombineButton.sprite = activatingSprite;
                textInside.text = "";
                buttonTransform.anchoredPosition = new Vector3(0, -486, 0);
                UseButton.SetActive(false);
            }
            else
            {
                CombineButton.sprite = inActivatingSprite;
                textInside.text = text;
                buttonTransform.anchoredPosition = new Vector3(0, -486, 0);
                UseButton.SetActive(false);
            }
        }
    }
}
