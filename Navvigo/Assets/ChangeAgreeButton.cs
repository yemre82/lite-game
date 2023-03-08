using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VectorGraphics;
using TMPro;

public class ChangeAgreeButton : MonoBehaviour
{
    public bool is_agree=false;
    public SVGImage buttonImage;
    public Sprite notAgreed;
    public Sprite agreed;
    public TMP_Text agreedText;


    // Start is called before the first frame update
    void Start()
    {
        if (is_agree)
        {
            buttonImage.sprite = agreed;
            agreedText.color = new Color(0.07450981f, 0.07450981f, 0.07450981f, 1);
        }
        else
        {
            buttonImage.sprite = notAgreed;
            agreedText.color = new Color(0.5333334f, 0.5333334f, 0.5333334f, 1);
        }
    }

    public void ChangeImageAndAgreed()
    {
        if (is_agree)
        {
            buttonImage.sprite = notAgreed;
            is_agree = false;
            agreedText.color = new Color(0.5333334f, 0.5333334f, 0.5333334f, 1);
        }
        else
        {
            buttonImage.sprite = agreed;
            is_agree = true;
            agreedText.color = new Color(0.07450981f, 0.07450981f, 0.07450981f, 1);
        }
    }
}
