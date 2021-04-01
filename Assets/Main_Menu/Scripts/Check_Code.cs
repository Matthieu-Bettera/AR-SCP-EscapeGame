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
    
    [SerializeField] 
    public string SceneMalO; 
    public string SceneTuyaux;
    public string SceneAR;

    private void Start()
    {
        LastPassword = "461829";
        Password_682 = "83";
        Password_Malo ="61"; 
    }
    public void ConfirmMachine()
    {
        SetMachines();
        Result = MachineText[0].text + MachineText[1].text;
        if(Result == Password_682)
        {
            Debug.Log("SCENE_682");
            SceneManager.LoadScene(SceneTuyaux);
        }
        if(Result == Password_Malo)
        {
            SceneManager.LoadScene(SceneMalO);
        }
    }
    public void ConfirmCode()
    {
        SetCode();
        Result = CodeText[0].text + CodeText[1].text + CodeText[2].text+ CodeText[3].text+ CodeText[4].text+ CodeText[5].text;
        if(Result == LastPassword)
        {
            Debug.Log("SCENE_FINAL");
            SceneManager.LoadScene(SceneAR);
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

    void SetMachines()
    {
        MachineText[0] = GameObject.Find("Machine Pos1").GetComponent<Text>();
        MachineText[1] = GameObject.Find("Machine Pos2").GetComponent<Text>();
    }

    void SetCode()
    {
        CodeText[0] = GameObject.Find("POS_1").GetComponent<Text>();
        CodeText[1] = GameObject.Find("POS_2").GetComponent<Text>();
        CodeText[2] = GameObject.Find("POS_3").GetComponent<Text>();
        CodeText[3] = GameObject.Find("POS_4").GetComponent<Text>();
        CodeText[4] = GameObject.Find("POS_5").GetComponent<Text>();
        CodeText[5] = GameObject.Find("POS_6").GetComponent<Text>();
    }
}