using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    public void DontdestroyOnLoad(){}

    public void StartCountdown()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "END";
    }

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
