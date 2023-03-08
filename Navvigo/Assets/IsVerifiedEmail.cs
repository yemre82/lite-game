using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VectorGraphics;
using TMPro;

public class IsVerifiedEmail : MonoBehaviour
{
    public bool isVerified = false;
    public SVGImage Image;
    public Sprite verified;
    public Sprite notVerified;
    public GameObject verifyButton;
    public GameObject editButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerified)
        {
            Image.sprite = verified;
            editButton.SetActive(true);
            verifyButton.SetActive(false);
        }
        else
        {
            Image.sprite = notVerified;
            editButton.SetActive(false);
            verifyButton.SetActive(true);
        }
    }
}
