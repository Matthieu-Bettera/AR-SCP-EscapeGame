using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndiceMenu : MonoBehaviour
{
    public Animator _IndiceAnim;
    public Animator _RevoirIndiceAnim;
    public void GoToMenu()
    {
        _IndiceAnim.SetBool("IsIndice", false);
        _IndiceAnim.SetBool("IsExit", true);
    }
    public void GoToIndice()
    {
        _IndiceAnim.SetBool("IsIndice", true);
    }

    public void GoToMenuBis()
    {
        _RevoirIndiceAnim.SetBool("IsIndice", false);
        _RevoirIndiceAnim.SetBool("IsExit", true);
    }
    public void GoToRevoirIndice()
    {
        _RevoirIndiceAnim.SetBool("IsIndice", true);
    }
}
