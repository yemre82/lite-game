using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VectorGraphics;
using TMPro;

public class CombineNftsChangingImage : MonoBehaviour
{
    public CombineNfts combine;
    public Sprite background;
    public Sprite background2;
    public Texture image;
    public Sprite countImage;
    public Sprite countImage2;
    public int count;
    public string titleText;
    public string percentageOrCountText;


    // Start is called before the first frame update
    void Start()
    {
        if (count > 0)
        {
            combine.background.sprite = background;
            combine.texture.texture = image;
            combine.countImage.sprite = countImage;
            combine.count.text = count.ToString();
            combine.title.text = titleText;
            combine.percentageOrCount.text = percentageOrCountText;
        }
        else if (count==0)
        {
            combine.background.sprite = background2;
            combine.texture.texture = image;
            combine.countImage.sprite = countImage2;
            combine.count.text = count.ToString();
            combine.title.text = titleText;
            combine.percentageOrCount.text = percentageOrCountText;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
