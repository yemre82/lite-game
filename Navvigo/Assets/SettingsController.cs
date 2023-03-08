using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VectorGraphics;
using TMPro;

public class SettingsController : MonoBehaviour
{
    public bool isVerifiedEmail=false;
    public SVGImage isVerifiedEmailImage;
    public Sprite verifiedEmail;
    public Sprite notVerifiedEmail;
    public bool isActiveNotifications=false;
    public SVGImage isActiveNotificationsImage;
    public Sprite activeNotifications;
    public Sprite notActiveNotifications;
    public TMP_Text titleText;
    public GameObject top;
    public Sprite topOn;
    public Sprite topOff;
    public GameObject OnText;
    public GameObject OffText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerifiedEmail)
        {
            isVerifiedEmailImage.sprite = verifiedEmail;
        }
        else
        {
            isVerifiedEmailImage.sprite = notVerifiedEmail;
        }

        if (isActiveNotifications)
        {
            isActiveNotificationsImage.sprite = activeNotifications;
            titleText.color = new Color(0.07450981f, 0.07450981f, 0.07450981f,1);
            top.GetComponent<SVGImage>().sprite = topOn;
            top.GetComponent<RectTransform>().anchoredPosition = new Vector3(104, 0, 0);
            OnText.SetActive(true);
            OffText.SetActive(false);
        }
        else
        {
            isActiveNotificationsImage.sprite = notActiveNotifications;
            titleText.color = new Color(0.3294118f, 0.9803922f, 0.5019608f, 1);
            top.GetComponent<SVGImage>().sprite = topOff;
            top.GetComponent<RectTransform>().anchoredPosition = new Vector3(4, 0, 0);
            OnText.SetActive(false);
            OffText.SetActive(true);
        }
    }
}
