using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string SceneName;
    IndiceButt _indice;
    public GameObject _Mawager;
    public void Switch()
    {
        
        _Mawager.GetComponent<IndiceButt>()._MalOOpen = false;
        _Mawager.GetComponent<IndiceButt>()._MalORes = true;
        _Mawager.GetComponent<IndiceButt>()._index = -1;
        SceneManager.LoadScene(SceneName);
    }
    public void Start()
    {
        _Mawager = GameObject.Find("Manager");
        _Mawager.GetComponent<IndiceButt>()._MalOOpen = true;
        _Mawager.GetComponent<IndiceButt>()._StartBool = false;
    }

    public void NormalSwitch()
    {
        SceneManager.LoadScene(SceneName);
    }
}
