using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    [SerializeField] //Puzzle
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    public GameObject _Puzzle;
    public GameObject _Interrogatoire;
    public GameObject _ExitButton;
    public GameObject _FondInterro;
    public GameObject _Bassin;
    float _WaitTime;
    public Image _WaitForButtonEffect;
    bool disableInterro;
    public GameObject _retour;

    [SerializeField]
    [Header("Tous les sons")]
    public AudioSource _MalOSound;
    public AudioSource _ThunderSound;
    public AudioSource _SunSound;
    public AudioSource _WaveSound;
    public AudioSource _FinalSound;

    public AudioSource _MalOPress;
    public AudioSource _ThunderPress;
    public AudioSource _SunPress;
    public AudioSource _WavePress;


    [Header("Flip Flop")]
    public string final_Word;
    public string good_job;
    public int findchar;
    public List<string> finalWord = new List<string>();
    public List<string> checkfinalWord = new List<string>();
    public Animator TrigAnim;
    int _id;

    [Header("Navig")]
    public string _scenemanger;
    GameObject _Mawager;


    // Start is called before the first frame update
    void Start()
    {
        _Mawager = GameObject.Find("Manager");
        winText.SetActive(false);
        youWin = false;
        good_job = "3421223";
        findchar = -1;
        _retour.SetActive(true);

        _Mawager.GetComponent<IndiceButt>()._SCP682 = true;
        _Mawager.GetComponent<IndiceButt>()._MalORes = false;
    }

    // Update is called once per frame
    void Update()
    {
        //énigme tuyau
        if (pictures[0].rotation.z == 0   &&
            pictures[1].rotation.z == 0   &&
            pictures[2].rotation.z == 0   &&
            pictures[3].rotation.z == 0   &&
            pictures[4].rotation.z == 0   &&
            pictures[5].rotation.z == 0   &&
            pictures[6].rotation.z == 0)
        {
            youWin = true;
            winText.SetActive(true);
            _Puzzle.SetActive(false);
            _Interrogatoire.SetActive(true);
            _FondInterro.SetActive(true);
            _Bassin.SetActive(true);

            if(disableInterro)
            {
                _Interrogatoire.SetActive(false);
                _ExitButton.SetActive(true);
            }
        }
    }
//Si tu touches le bon bouton
    public void LogoPressed(int WichButton)
    {
        
    }

    //Boutons Interrogatoire
    public void butMalO()
    {
        _id = 1;
        _WaitTime = 7f;
        findchar++;
        StartCoroutine(WaitForNextSound());
        string but = "1";
        final_Word = final_Word + but;
        checkfinalWord[findchar] = but;
        checkword();
    }

    public void butThunder()
    {
        _id = 2;
        _WaitTime = 4f;
        findchar++;
        StartCoroutine(WaitForNextSound());
        string but = "2";
        final_Word = final_Word + but;
        checkfinalWord[findchar] = but;
        checkword();
    }

    public void butSun()
    {
        _id =3;
        _WaitTime = 4f;
        findchar++;
        StartCoroutine(WaitForNextSound());
        string but = "3";
        final_Word = final_Word + but;
        checkfinalWord[findchar] = but;
        checkword();
    }

    public void butWave()
    {
        _id = 4;
        _WaitTime = 4f;
        findchar++;
        StartCoroutine(WaitForNextSound());
        string but = "4";
        final_Word = final_Word + but;
        checkfinalWord[findchar] = but;
        checkword();
    }
    void checkword()
    {
        if(finalWord[findchar] != checkfinalWord[findchar])
            {
                resetWord();
            }
    }

    void resetWord()
    {
        checkfinalWord[0] = "";
        checkfinalWord[1] = "";
        checkfinalWord[2] = "";
        checkfinalWord[3] = "";
        checkfinalWord[4] = "";
        checkfinalWord[5] = "";
        checkfinalWord[6] = "";
        findchar =-1;
    }

    public void Retour()
    {
        _Mawager.GetComponent<IndiceButt>()._SCP682 = false;
        _Mawager.GetComponent<IndiceButt>()._SCP682Res = true;
        _Mawager.GetComponent<IndiceButt>()._index = -1;
        SceneManager.LoadScene(_scenemanger);
    }

    public void NormalRetour()
    {
        SceneManager.LoadScene(_scenemanger);
    }

    IEnumerator PlayLastSound()
    {

        yield return new WaitForSeconds(4f);
        _FinalSound.Play();

        yield return new WaitForSeconds(34f);
        _WaitForButtonEffect.enabled = false;
        _retour.SetActive(false);
    }

    IEnumerator WaitForNextSound()
    {
        _WaitForButtonEffect.enabled = true;
        if(_id == 1)
        {            
            _MalOPress.Play();
            yield return new WaitForSeconds(4f);
            _MalOSound.Play();
        }
        if(_id == 2)
        {            
            _ThunderPress.Play();
            yield return new WaitForSeconds(4f);
            _ThunderSound.Play();
        }
        if(_id == 3)
        {            
            _SunPress.Play();
            yield return new WaitForSeconds(4f);
            _SunSound.Play();
        }
        if(_id ==4)
        {            
            _WavePress.Play();
            yield return new WaitForSeconds(4f);
            _WaveSound.Play();
        } 

        if(findchar == 6)
        {
            StartCoroutine(PlayLastSound());
            yield return new WaitForSeconds(34f);
            disableInterro = true;
        } else {
        yield return new WaitForSeconds(_WaitTime);
        _WaitForButtonEffect.enabled = false;
        }
    }
}