using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenControler : MonoBehaviour
{

    public Material screenOff;
    public Material screenOn;
    MeshRenderer screenRenderer;

    [SerializeField]Transform linkedPosition;

    public CheckStatuePresence presence;

    // Start is called before the first frame update
    void Start()
    {
        screenRenderer = this.gameObject.GetComponent<MeshRenderer>();

        screenRenderer.material = screenOff;
    }

    // Update is called once per frame
    void Update()
    {
        if (presence.statueIsHere == true)
        {
            screenRenderer.material = screenOn;
        }
        else
        {
            screenRenderer.material = screenOff;
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, linkedPosition.position);
    }
}
