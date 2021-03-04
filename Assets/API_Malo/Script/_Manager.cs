using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Manager : MonoBehaviour
{
    public int CurrentChar; 
    public string WordToDisplay;
    public int MaxLength;
    public Text TipeBar; 

    void Start()
    {
       
    }

    void Update()
    {
       
        TipeBar.text = WordToDisplay;
    }
    public void DeleteString()
    {
        string Deleted = "";
        WordToDisplay = Deleted;
        CurrentChar = 0;
    }
}
