using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectTransformChanger : MonoBehaviour
{
    public RectTransform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
