using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Check_Code : MonoBehaviour
{

    string Password_Malo;
    string Password_682;
    string LastPassword;
    string Result;
    public List<Text> MachineText = new List<Text>();
    public List<Text> CodeText = new List<Text>();
    public List<Text> RapportText = new List<Text>();
    public List<Rapports> Rapport_SCP = new List<Rapports>();
    [SerializeField] string SceneName; 

    private void Start()
    {
        LastPassword = "461829";
        Password_682 = "83";
        Password_Malo ="61"; 
    }
    public void ConfirmMachine()
    {
        Result = MachineText[0].text + MachineText[1].text;
        if(Result == Password_682)
        {
            Debug.Log("SCENE_682");
        }
        if(Result == Password_Malo)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
    public void ConfirmCode()
    {
        Result = CodeText[0].text + CodeText[1].text + CodeText[2].text+ CodeText[3].text+ CodeText[4].text+ CodeText[5].text;
        if(Result == LastPassword)
        {
            Debug.Log("SCENE_FINAL");
        }
    }
    public void ConfirmRapport()
    {
     Result = RapportText[0].text + RapportText[1].text + RapportText[2].text;
        foreach (Rapports _rapport in Rapport_SCP) 
        { 
            if(Result == _rapport.Code)
            {
                _rapport.Rapport_Enable();
            }
        }
    }
}
