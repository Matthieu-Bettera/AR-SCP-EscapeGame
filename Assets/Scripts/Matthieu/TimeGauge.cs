using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeGauge : MonoBehaviour
{
    public float timeMultiplier = 0.2f;

    public float startValue = 0;

   [SerializeField] private Slider slider;

    private void Start()
    {
        slider.value = startValue;
    }


    public void AugmentTime()
    {
        slider.value += Time.deltaTime * timeMultiplier;
    }
}
