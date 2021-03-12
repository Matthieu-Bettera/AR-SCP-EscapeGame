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


       Debug.Log(TPPositions[randomPos].transform.rotation);
        int rot=90;

    

        switch (randomPos)
        {
            case 0:
                rot = 90;
                break;
            case 1:
                rot = -90;
                break;
            case 2:
                rot = 180;
                break;
            case 3:
                rot = 180;
                break;
            default:
                break;
        }

        Vector3 rotationV = new Vector3(-90, 0, rot);

        this.gameObject.transform.rotation = Quaternion.Euler(rotationV);




    }
}
