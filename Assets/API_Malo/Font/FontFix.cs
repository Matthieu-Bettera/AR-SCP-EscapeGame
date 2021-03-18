using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FontFix : MonoBehaviour
{
    public Font _font;
    void Start()
    {
        _font.material.mainTexture.filterMode = FilterMode.Point;
    }

    
   
}
