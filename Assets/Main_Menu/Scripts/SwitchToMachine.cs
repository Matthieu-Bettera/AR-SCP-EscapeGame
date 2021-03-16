using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToMachine : MonoBehaviour
{
    [SerializeField]private Animator BlackScreen_Machine;
    [SerializeField] private Animator BlackScreen_Code;
    // Start is called before the first frame update
 
    public void ShowMachine()
    {
        BlackScreen_Machine.SetBool("Fade", true);
        BlackScreen_Machine.SetBool("FadeOut", false);
    }
    public void ShowCode()
    {
        BlackScreen_Code.SetBool("Fade", true);
        BlackScreen_Code.SetBool("FadeOut", false);
    }
    public void CodeToMenu()
    {
              
        BlackScreen_Code.SetBool("FadeOut", true);
        BlackScreen_Code.SetBool("Fade", false);
    }
    public void MachineToMenu()
    {
       
        BlackScreen_Machine.SetBool("FadeOut", true);
        BlackScreen_Machine.SetBool("Fade", false);
    }
}
