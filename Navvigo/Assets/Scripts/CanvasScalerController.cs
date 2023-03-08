using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScalerController : MonoBehaviour
{
    public CanvasScaler scaler;
    public GameObject splashScreen;
    public Animator splashScreenAnimator;
    public GameObject loginScreen;
    public GameObject LoginEmailDoneScreen;

    // Start is called before the first frame update
    void Start()
    {
        scaler.matchWidthOrHeight = 0f;
        StartCoroutine(delayedSplashScreen(splashScreenAnimator.GetCurrentAnimatorStateInfo(0).length));
    }

    IEnumerator delayedSplashScreen(float time)
    {
        yield return new WaitForSeconds(time);
        if (PlayerPrefs.HasKey("email"))
        {
            PlayerPrefs.SetString("tempEmail", PlayerPrefs.GetString("email"));
            splashScreen.SetActive(false);
            LoginEmailDoneScreen.SetActive(true);
            loginScreen.SetActive(false);
            scaler.matchWidthOrHeight = 1f;
        }
        else
        {
            splashScreen.SetActive(false);
            LoginEmailDoneScreen.SetActive(false);
            loginScreen.SetActive(true);
            scaler.matchWidthOrHeight = 1f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
