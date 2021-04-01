using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMachin : MonoBehaviour
{
    public Animator ErrorTrigg;

        public void ResetError()
    {
        ErrorTrigg.SetBool("Error", false);
    }
}
