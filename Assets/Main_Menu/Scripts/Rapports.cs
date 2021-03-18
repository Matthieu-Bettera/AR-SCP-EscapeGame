using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Rapports : ScriptableObject
{
    public string Code;
    public GameObject Rapport;

   public void Rapport_Enable()
    {
        Rapport.SetActive(true);
    }

   public void Rapport_Disable()
    {
        Rapport.SetActive(false);
    }
    
   
    
}
