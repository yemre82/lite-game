using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuController : MonoBehaviour
{
    public GameObject splashScreen;
    public Animator splashScreenAnimator;

    public GameObject loginScreen;
    public GameObject loginScreen2;


    public TMP_InputField email;
    // Start is called before the first frame update
    void Start()
    {
        splashScreen.SetActive(true);
        loginScreen.SetActive(false);
        loginScreen2.SetActive(false);
        StartCoroutine(delayedSplashScreen(splashScreenAnimator.GetCurrentAnimatorStateInfo(0).length));
    }

    IEnumerator delayedSplashScreen(float time)
    {
        yield return new WaitForSeconds(time);
        if (PlayerPrefs.HasKey("email"))
        {
            splashScreen.SetActive(false);
            loginScreen2.SetActive(true);
            loginScreen.SetActive(false);
        }
        else
        {
            splashScreen.SetActive(false);
            loginScreen2.SetActive(false);
            loginScreen.SetActive(true);
        }
        
    }

    public void DoneButtonInLoginScreen()
    {
        PlayerPrefs.SetString("email", email.text);
        splashScreen.SetActive(false);
        loginScreen.SetActive(false);
        loginScreen2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
