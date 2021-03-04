using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportStatue : MonoBehaviour
{

    [SerializeField] Transform[] TPPositions;

    public float startTime=5f;
    public float countdownTime;


    // Start is called before the first frame update
    void Start()
    {
        Teleport();
        countdownTime = startTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownTime <= 0)
        {
            Teleport();
            countdownTime = startTime;
           
        }
        else
        {
            countdownTime -= Time.deltaTime;
        }
    }


    void Teleport()
    {
        int randomPos = Random.Range(0, TPPositions.Length);

        this.gameObject.transform.position = TPPositions[randomPos].transform.position;
    }
}
