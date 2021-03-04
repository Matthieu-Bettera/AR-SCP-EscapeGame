using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectNumber : MonoBehaviour
{
    _Manager manager;
    Text NumberAccurate;
    public char NumberToDisplay;
    int MaxCharacter ;
 string CurrentWord;
   public int _CurrentChar; 
    public List<char> Word = new List<char>();
    
    void Start()
    {
        manager = GameObject.Find("CharManager").GetComponent<_Manager>(); 
        NumberAccurate = gameObject.GetComponentInChildren<Text>();
       NumberToDisplay = NumberAccurate.text[0];
    }

    // Update is called once per frame
    void Update()
    {
        Initiate();
      /*  if (_CurrentChar > 2)
        {
            _CurrentChar = 2;
        }*/
    }
    public void Detect()
    {
        


        if (_CurrentChar < MaxCharacter)
        {   manager.GetComponent<_Manager>().CurrentChar++;
            manager.GetComponent<_Manager>().WordToDisplay += NumberToDisplay;
        }
        else
        {
            CurrentWord = manager.GetComponent<_Manager>().WordToDisplay.Substring(0,MaxCharacter-1);
            manager.GetComponent<_Manager>().WordToDisplay = CurrentWord + NumberToDisplay;
            Debug.Log(CurrentWord);
           
        }
       
        
       

    }
    void Initiate()
    {
        MaxCharacter = manager.GetComponent<_Manager>().MaxLength;
        _CurrentChar = manager.GetComponent<_Manager>().CurrentChar;
      
    }
}
