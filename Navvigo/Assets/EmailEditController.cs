using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VectorGraphics;
using TMPro;
using System.Text.RegularExpressions;

public class EmailEditController : MonoBehaviour
{
    public TMP_InputField inputField;
    public SVGImage DoneButton;
    public Sprite done;
    public Sprite notDone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        if (emailRegex.IsMatch(inputField.text))
        {
            DoneButton.sprite = done;
        }
        else
        {
            DoneButton.sprite = notDone;
        }
    }
}
