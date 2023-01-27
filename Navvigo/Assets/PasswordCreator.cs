using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VectorGraphics;
using TMPro;

public class PasswordCreator : MonoBehaviour
{
    public string password;
    public int passwordSize=6;
    public List<SVGImage> passwordCircle;
    public Sprite black;
    public Sprite white;
    public Sprite green;
    public Sprite red;

    private bool canEdit=true;
    public TMP_Text email;
    public void AddPass(int number)
    {
        if (!PasswordOkey()&&canEdit)
        {
            password += number.ToString();
            DrawCircle();
            if (PasswordOkey())
            {
                CheckPassword();
            }
        }
    }

    public void DeletePass()
    {
        if (password.Length > 0&&canEdit)
        {
            password=password.Remove(password.Length-1,1);
            DrawCircle();
        }
    }

    public bool PasswordOkey()
    {
        if (password.Length == passwordSize)
        {
            return true;
        }
        return false;
    }

    public void DrawCircle()
    {
        for (int i = 0; i < passwordCircle.Count; i++)
        {
            passwordCircle[i].sprite = white;
        }

        for (int i = 0; i < password.Length; i++)
        {
            passwordCircle[i].sprite = black;
        }
    }

    public void CheckPassword()
    {
        if (password == "123456")
        {
            for(int i = 0; i < passwordCircle.Count; i++)
            {
                passwordCircle[i].sprite = green;
            }
            password = "";
            canEdit = false;
        }
        else
        {
            for (int i = 0; i < passwordCircle.Count; i++)
            {
                passwordCircle[i].sprite = red;
            }
            password = "";
            canEdit = false;
            StartCoroutine(DelayedChangeCircleToWhite());
        }
    }

    IEnumerator DelayedChangeCircleToWhite()
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < passwordCircle.Count; i++)
        {
            passwordCircle[i].sprite = white;
        }
        canEdit = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("email"));
        email.text = PlayerPrefs.GetString("email");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
