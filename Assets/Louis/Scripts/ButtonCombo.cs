using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum KeyType {MalO = 0, Thunder = 1, Sun = 2, Wave = 3};
public class ButtonCombo : MonoBehaviour
{
    [Header("Inputs")]
    public KeyCode MalOKey;
    public KeyCode ThunderKey;
    public KeyCode SunKey;
    public KeyCode WaveKey;

    [Header("Pressed")]
    public Pressed _MalOKey;
    public Pressed _ThunderKey;
    public Pressed _SunKey;
    public Pressed _WaveKey;
    public List<Combo> combos;
    public float comboLeeway = 0.2f;

    [Header("Components")]
    Animator ani;

    Pressed curAttack = null;
    ComboInput lastInput = null;
    List<int> currentCombos = new List<int>();
    float timer = 0;
    float Leeway = 0;
    bool skip = false;

    void Start()
    {
        ani = GetComponent<Animator>();
        PrimeCombo();
    }

    void PrimeCombo()
    {
        for(int i = 0; i < combos.Count; i++)
        {
            Combo c = combos[i];
            c.onCombo.AddListener(() => 
            {
                //Call attack function with the combo's attack
                skip = true;
                Attack(c.comboPressed);
                ResetCombos();
            }
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(curAttack != null)
        {
            if(timer > 0)
        timer -= Time.deltaTime;
            else
            curAttack = null;

            return;
        }

        if(currentCombos.Count > 0)
        {
            Leeway += Time.deltaTime;
            if(Leeway >= comboLeeway)
            {
                if(lastInput != null)
                {
                    Attack(GetAttackFromType(lastInput.type));
                    lastInput = null;
                }
                ResetCombos();
            }
        }
        else
            Leeway = 0;

        ComboInput input = null;
        if(Input.GetKeyDown(MalOKey))
            input = new ComboInput(KeyType.MalO);
        if(Input.GetKeyDown(ThunderKey))
            input = new ComboInput(KeyType.Thunder);
        if(Input.GetKeyDown(SunKey))
            input = new ComboInput(KeyType.Sun);
        if(Input.GetKeyDown(WaveKey))
            input = new ComboInput(KeyType.Wave);

        if(input == null) return;
        lastInput = input;
        
        List<int> remove = new List<int>();
        for(int i = 0; i < currentCombos.Count; i++)
        {
            Combo c = combos[currentCombos[i]];
            if(c.continueCombo(input))
                Leeway = 0;
            else
             remove.Add(i);
        }

        if(skip)
        {
            skip = false;
            return;
        }

        for(int i = 0; i < combos.Count; i++)
        {
            if(currentCombos.Contains(i)) continue;
            if(combos[i].continueCombo(input))
            {
                currentCombos.Add(i);
                Leeway = 0;
            }
        }

        foreach (int i in remove)
        currentCombos.RemoveAt(i);

        if(currentCombos.Count <= 0)
            Attack(GetAttackFromType(input.type));
    }

    void ResetCombos()
    {
        Leeway = 0;
        for(int i = 0; i < currentCombos.Count; i++)
        {
            Combo c = combos[currentCombos[i]];
            c.ResetCombo();
        }

        currentCombos.Clear();
    }

    void Attack(Pressed att)
    {
        curAttack = att;
        timer = att.length;
        ani.Play(att.name, -1, 0);
    }

    Pressed GetAttackFromType(KeyType t)
    {
        if(t == KeyType.MalO)
            return _MalOKey;
        if(t == KeyType.Thunder)
            return _ThunderKey;
        if(t == KeyType.Sun)
            return _SunKey;
        if(t == KeyType.Wave)
            return _WaveKey;
        return null;
    }
}

[System.Serializable]
public class Pressed
{
    public string name;
    public float length;
}

[System.Serializable]
public class ComboInput
{
    public KeyType type;
    //Movement input for more precise combo

    public ComboInput(KeyType t)
    {
        type = t;
    }

    public bool isSameAs(ComboInput test)
    {
        return (type == test.type); //Add && movement == test.movement
    }
}

[System.Serializable]
public class Combo
{
    public List<ComboInput> inputs;
    public Pressed comboPressed;
    public UnityEvent onCombo;
    int curInput = 0;

    public bool continueCombo(ComboInput i)
    {
        if(i.type == inputs[curInput].type) //Add && i.movement == Inputs[curInputs].movement
        {
            curInput++;
            if(curInput >= inputs.Count) //Finished the inputs and do the attack
            {
                onCombo.Invoke();
                curInput = 0;
            }
            return true;
        }
        else
        {
            curInput = 0;
            return false;
        }
    }

    public ComboInput currentComboInput()
    {
        if(curInput >= inputs.Count) return null;
        return inputs[curInput];
    }

    public void ResetCombo()
    {
        curInput = 0;
    }
}