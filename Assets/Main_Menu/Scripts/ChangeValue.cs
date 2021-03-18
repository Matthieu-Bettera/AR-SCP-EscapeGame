using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeValue : MonoBehaviour
{
    public Text AccurateText;
    int StartValue;
   
  
    void Start()
    {
        StartValue = 0;
    }

    void Update()
    {
        AccurateText.text = "" + StartValue; 
        
        
       
    }
 
    public void ADD()
    {
        StartValue++;
        if (StartValue > 9)
        {
            StartValue = 0;
        }
    }
    public void SUBSTRACT()
    {
        StartValue--;
        if (StartValue < 0)
        {
            StartValue = 9;
        }
    }
}
