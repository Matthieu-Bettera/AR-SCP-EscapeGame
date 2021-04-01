using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    int _timeInMinutes;
    public float _timeInSeconds;
    public bool timeIsRunning = false;
    string _Timer;
    public Text _timerDisplay;
    bool _launchTimer;
    string displaySeconds;
    float _lesSecondes;
    public GameObject _CanvasText;
    int _search;
    static bool created;

    public void Awake()
    {
        if(!created)
        {
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(_CanvasText);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
            Destroy(_CanvasText);
        }
    }
        private void Start()
    {
        timeIsRunning = true;
        _timeInMinutes = 44;
    }

    void Update()
    {
        if(_timeInSeconds < 0)
        {
            _timeInMinutes --;
            _timeInSeconds = 60;
        }

        if(_timeInMinutes < 0)
        {
            Debug.Log("Loose");
            _Timer = "0:0";
        }
        else
        {
            _Timer = _timeInMinutes + ":" + displaySeconds;
            _timerDisplay.text = _Timer;
        }

        if(_launchTimer)
        {
            _timeInSeconds -= Time.deltaTime;
            _lesSecondes = (int)(_timeInSeconds%60);
            displaySeconds = "" + _lesSecondes;
        }
    }
    public void Malus()
    {
        _timeInSeconds -= 5;
    }

    public void PlayTimer()
    {
        _launchTimer = true;
    }
}