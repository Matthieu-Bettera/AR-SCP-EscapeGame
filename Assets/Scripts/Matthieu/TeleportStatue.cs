using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportStatue : MonoBehaviour
{

    [SerializeField] Transform[] TPPositions;

    public float startTime=5f;
    public float countdownTime;
    public float speed = 30;

    //Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
        Teleport(Random.Range(0, TPPositions.Length));
        countdownTime = startTime;
       
        
    }

    // Update is called once per frame
    void Update()
    {


        if (countdownTime <= 0)
        {
            Teleport(Random.Range(0, TPPositions.Length));         
            countdownTime = startTime;
           
        }
        else
        {
            countdownTime -= Time.deltaTime;
        }

       
    }

  


    void Teleport(int pos)
    {

  
        Vector3 direction = TPPositions[pos].transform.position;


        this.transform.position = direction;


       
        int rot=90;

    

        switch (pos)
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
                rot = 360;
                break;
            case 4:
                rot = 90;
                break;
            default:
                break;
        }

        Vector3 rotationV = new Vector3(-90, 0, rot);

        this.gameObject.transform.rotation = Quaternion.Euler(rotationV);




    }
}
