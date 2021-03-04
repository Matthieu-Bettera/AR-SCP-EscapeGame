using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStatuePresence : MonoBehaviour
{

    public bool statueIsHere = false;
   

    private void Update()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, 0.3f,Vector3.forward);

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


}
