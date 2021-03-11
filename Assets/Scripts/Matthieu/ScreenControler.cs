using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenControler : MonoBehaviour
{

    public Material m_screenOff;
    public Material m_screenOn;
    MeshRenderer screenRenderer;

    public bool screenIsOn=false;

    [SerializeField]Transform linkedPosition;

    //public CheckStatuePresence presence;

    // Start is called before the first frame update
    void Start()
    {
        screenRenderer = this.gameObject.GetComponent<MeshRenderer>();

        screenRenderer.material = m_screenOff;
    }

    // Update is called once per frame
    void Update()
    {
        if (screenIsOn == true)
        {
            screenRenderer.material = m_screenOn;
        }
        else
        {
            screenRenderer.material = m_screenOff;
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, linkedPosition.position);
    }
}
