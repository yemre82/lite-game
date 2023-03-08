using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionsController : MonoBehaviour
{
    public GameObject EmailPanel;
    public GameObject CloverPanel;
    public GameObject SharePanel;


    // Start is called before the first frame update
    void Start()
    {
        EmailPanel.SetActive(true);
        SharePanel.SetActive(false);
        CloverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (EmailPanel.activeInHierarchy)
        {
            this.gameObject.GetComponent<Image>().color = new Color(0.627451f, 0.4352941f, 0.9137255f,1);
        }else if(CloverPanel.activeInHierarchy)
        {
            this.gameObject.GetComponent<Image>().color = new Color(0.3294118f, 0.9803922f, 0.5019608f, 1);
        }
        else if (SharePanel.activeInHierarchy)
        {
            this.gameObject.GetComponent<Image>().color = new Color(0.3058824f, 0.9176471f, 1f, 1);
        }
    }

    public void Next()
    {
        if (EmailPanel.activeInHierarchy)
        {
            EmailPanel.SetActive(false);
            CloverPanel.SetActive(true);
        }
        else if (CloverPanel.activeInHierarchy)
        {
            CloverPanel.SetActive(false);
            SharePanel.SetActive(true);
        }
        else if (SharePanel.activeInHierarchy)
        {
            SharePanel.SetActive(false);
            EmailPanel.SetActive(true);
        }
    }

    public void Previous()
    {
        if (EmailPanel.activeInHierarchy)
        {
            EmailPanel.SetActive(false);
            SharePanel.SetActive(true);
        }
        else if (CloverPanel.activeInHierarchy)
        {
            CloverPanel.SetActive(false);
            EmailPanel.SetActive(true);
        }
        else if (SharePanel.activeInHierarchy)
        {
            SharePanel.SetActive(false);
            CloverPanel.SetActive(true);
        }
    }
}
