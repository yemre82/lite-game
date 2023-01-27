using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class RegexController : MonoBehaviour
{
    public TMP_InputField email;
    public ChangeButtonImage button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(email.text);
        if (match.Success)
            button.button.interactable = true;
        else
            button.button.interactable = false;
    }

    
}
