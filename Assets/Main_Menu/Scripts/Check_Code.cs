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
    [SerializeField] string SceneName; 

    private void Start()
    {
        LastPassword = "333433";
        Password_682 = "682";
        Password_Malo ="471"; 
    }
    public void ConfirmMachine()
    {
        Result = MachineText[0].text + MachineText[1].text + MachineText[2].text;
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
}
