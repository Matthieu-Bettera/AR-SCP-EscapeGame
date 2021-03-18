using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] //Puzzle
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    public GameObject _Puzzle;
    public GameObject _Interrogatoire;

    [SerializeField]
    [Header("Tous les sons")]
    public AudioSource _MalOSound;
    public AudioSource _ThunderSound;
    public AudioSource _SunSound;
    public AudioSource _WaveSound;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
        
        
        /*trouver comment donner un ordre pour les boutons
        LogoSelect = 
        */
    }

    // Update is called once per frame
    void Update()
    {
        //énigme tuyau
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0)
        {
            youWin = true;
            winText.SetActive(true);
            _Puzzle.SetActive(false);
            _Interrogatoire.SetActive(true);
        }
    }

//Si tu touches le bon bouton
    public void LogoPressed(int WichButton)
    {
        /*
        if(LogoSelect == WichButton)
        {
            Debug.Log("Correct");
        } else {
            Debug.Log("Wrong");
        }
        */
    }

    public void PlaySoundEffectMalO()
    {
        _MalOSound.Play();
    }
    public void PlaySoundEffectThunder()
    {
        _ThunderSound.Play();
    }
    public void PlaySoundEffectSun()
    {
        _SunSound.Play();
    }
    public void PlaySoundEffectWave()
    {
        _WaveSound.Play();
    }
}
