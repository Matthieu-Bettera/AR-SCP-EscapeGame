using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_UI : MonoBehaviour
{
    [SerializeField] private GameObject MainMenu_UI;
    [SerializeField] private GameObject Other_UI;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void UI_disabler()
    {
        Other_UI.SetActive(false);
        MainMenu_UI.SetActive(false);
    }
    public void UI_Enabler()
    {
        Other_UI.SetActive(true);
        MainMenu_UI.SetActive(true);
    }
}
