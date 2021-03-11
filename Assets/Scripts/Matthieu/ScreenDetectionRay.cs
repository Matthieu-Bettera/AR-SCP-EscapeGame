using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDetectionRay : MonoBehaviour
{
    [SerializeField] Transform rayPointer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = rayPointer.transform.TransformDirection(Vector3.right);

        Vector3 direction = fwd;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, direction, out hit))
        {

            Debug.Log(hit.collider);
            if (hit.collider != null)
            {
                if (hit.collider.tag == ("Player"))
                {
                    Debug.Log("c touché");

                }
                else
                {
                    // gauge.AugmentTime();
                }
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Vector3 fwd = rayPointer.transform.TransformDirection(transform.right);
        Gizmos.DrawLine(transform.position,fwd*10 );
    }
}
