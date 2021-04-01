using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetButton : MonoBehaviour
{
SwitchToMachine _SwitchToMachine;
Countdown _TimerSetting;
GameObject _GameManager;
Check_Code _validate;
IndiceButt _indice;

    private void Start()
    {
        SetAll();
    }
    void SetAll()
    {
        _GameManager = GameObject.Find("Manager");
        _SwitchToMachine = _GameManager.GetComponent<SwitchToMachine>();
        _TimerSetting = _GameManager.GetComponent<Countdown>();

        _validate = _GameManager.GetComponent<Check_Code>();
        _indice = _GameManager.GetComponent<IndiceButt>();
    }

    public void ButtTimer()
    {
        _TimerSetting.PlayTimer();
    }
    public void ButtMachine()
    {
        _SwitchToMachine.ShowMachine();
    }
    public void ButtMalus()
    {
        _TimerSetting.Malus();
    }
    public void ButtCode()
    {
        _SwitchToMachine.ShowCode();
    }
    public void ButtIndices()
    {
        _indice.Indices();
    }
    public void ButtRevoirIndices()
    {
        _indice.RevoirIndice();
    }

    public void SwitchToCodeMain()
    {
        _SwitchToMachine.CodeToMenu();
    }

    public void SwitchToMachineMain()
    {
        _SwitchToMachine.MachineToMenu();
    }

    public void ConfirmCode()
    {
        _validate.ConfirmCode();
    }
    public void ConfirmMachine()
    {
        _validate.ConfirmMachine();
    }
}
