using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStatuePresence : MonoBehaviour
{

    public bool statueIsHere = false;
    public float range = 0.3f;

    private void Update()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, range,Vector3.one);

        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.gameObject.tag == "Statue")
            {
               
                statueIsHere = true;
            }
            else
            {
                statueIsHere = false;
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        Gizmos.DrawWireSphere(transform.position, range);
    }


}
