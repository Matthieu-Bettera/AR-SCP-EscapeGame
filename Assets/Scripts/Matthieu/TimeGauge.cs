using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeGauge : MonoBehaviour
{
    public float timeMultiplier = 0.1f;

    public float startValue = 0;

   [SerializeField] private Slider slider;

    public static TimeGauge instance;

   Countdown _Countdown;
    GameObject _MalusObj;

    float malustimer;
    bool CanMalus;
  
    private void Start()
    {
        instance = this;
        slider.value = startValue;

        _MalusObj = GameObject.Find("Manager");
        _Countdown = _MalusObj.GetComponent<Countdown>();

    }

    private void Update()
    {
        if (slider.value == 0 && CanMalus == true)
        {
         
            _Countdown.Malus();
          
        }

        if (slider.value == 0)
        {
            malustimer += Time.deltaTime;
            CanMalus = true;
        }
        if (malustimer >= 0.2f)
        {
            
            CanMalus = false;
        }

        if (malustimer >= 3)
        {
           
            CanMalus = true;
            malustimer = 0;
        }
    }


    public void AugmentTime()
    {
        slider.value -= Time.deltaTime * timeMultiplier;
    }

    public void DescendTime()
    {
        slider.value += Time.deltaTime * timeMultiplier;
    }
}
