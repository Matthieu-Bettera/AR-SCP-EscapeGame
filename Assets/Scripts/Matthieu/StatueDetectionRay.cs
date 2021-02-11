using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class StatueDetectionRay : MonoBehaviour
{
    public Vector3 direction;
    public float distance;
    public TimeGauge gauge;
    public GameObject eyes;
    public GameObject player;

    [SerializeField] private Color gizmoColor;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        direction =  player.transform.position- eyes.transform.position;

        RaycastHit hit;

        if(Physics.Raycast(eyes.transform.position,direction,out hit,distance))
        {

            Debug.Log(hit.collider);
            if (hit.collider!=null)
            {
                if (hit.collider.tag == ("Statue"))
                {
                    Debug.Log("c touché");
                }
            }




        }
        else
        {
            gauge.AugmentTime();
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        direction = player.transform.position - eyes.transform.position;

        Gizmos.DrawRay(eyes.transform.position, direction );
    }
}
