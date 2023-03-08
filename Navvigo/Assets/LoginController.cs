using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;
using Newtonsoft.Json;
using Unity.VectorGraphics;

public class LoginController : MonoBehaviour
{
    public TMP_InputField email;
    public GameObject nextPage;
    public GameObject message;
    private Animator anim;
    public GameObject indicator;
    public Button doneButton;
    public string baseUrl = "http://127.0.0.1:8000/";
    public string childUrl = "api/user/validations/is-email-valid";


    public void DoneButton()
    {
        if(doneButton.GetComponent<ChangeButtonImage>().svg.sprite== doneButton.GetComponent<ChangeButtonImage>().interactableSprite)
        {
            indicator.SetActive(true);
            doneButton.interactable = false;
            PlayerPrefs.SetString("tempEmail", email.text);
            IsEmailValidService();
        }
    }

    public void IsEmailValidService()
    {
        StartCoroutine(Service());
    }

    IEnumerator Service()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", PlayerPrefs.GetString("tempEmail"));
        UnityWebRequest request = UnityWebRequest.Post(baseUrl + childUrl, form);
        yield return request.SendWebRequest();
        indicator.SetActive(false);
        doneButton.interactable = true;
        if (request.result == UnityWebRequest.Result.ConnectionError)
        {
            message.SetActive(true);
            message.GetComponentInChildren<TMP_Text>().text = "Connection Error!!";
            anim.SetBool("deger", true);
            StartCoroutine(delayedMessage(anim.GetCurrentAnimatorStateInfo(0).length));
        }
        else
        {
            var response = JsonConvert.DeserializeObject<IsEmailValidModel>(request.downloadHandler.text);
            if (response.error)
            {
                Debug.Log(response.errorMsg.ToString());
                message.SetActive(true);
                message.GetComponentInChildren<TMP_Text>().text = response.errorMsg.ToString();
                anim.SetBool("deger", true);
                StartCoroutine(delayedMessage(anim.GetCurrentAnimatorStateInfo(0).length));
            }
            else
            {
                nextPage.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }

    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        anim.SetBool("deger", false);
        message.SetActive(false);
        message.GetComponentInChildren<TMP_Text>().text = "";
    }

    IEnumerator delayedMessage(float time)
    {
        yield return new WaitForSeconds(time);
        anim.SetBool("deger", false);
        message.SetActive(false);
        message.GetComponentInChildren<TMP_Text>().text = "";
    }
}

public class IsEmailValidModel
{
    public bool error { get; set; }
    public object errorMsg { get; set; }
    public object data { get; set; }
}