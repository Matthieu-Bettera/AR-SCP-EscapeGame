using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFace : MonoBehaviour
{
    public Transform cameraPos;

    public List<Transform> faces;

    [SerializeField] private Transform visibleFace = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
        float min = 1;

        foreach (Transform face in faces)
        {
            Vector3 cameraToFace = (face.position - cameraPos.position).normalized;
            float dot = Vector3.Dot(face.up, cameraToFace);

            if (min > dot)
            {
                min = dot;
                visibleFace = face;

                
            }

       


        }

        foreach (Transform face in faces)
        {

            ScreenControler screen = face.gameObject.GetComponent<ScreenControler>();
            screen.screenIsOn = false;
          
        }
        ScreenControler visibleScreen = visibleFace.gameObject.GetComponent<ScreenControler>();
        visibleScreen.screenIsOn = true;




    }
}
