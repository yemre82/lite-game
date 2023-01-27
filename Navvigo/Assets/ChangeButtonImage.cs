using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VectorGraphics;

public class ChangeButtonImage : MonoBehaviour
{
    public SVGImage svg;
    public Sprite interactableSprite;
    public Sprite notInteractableSprite;
    public Button button;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeInteractable()
    {
        if (!button.interactable)
        {
            svg.sprite = notInteractableSprite;
        }
        else
        {
            svg.sprite = interactableSprite;
        }
    }



    // Update is called once per frame
    void Update()
    {
        ChangeInteractable();
    }
}
