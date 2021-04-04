using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class _Manager : MonoBehaviour
{
    [Header("END SCREEN")]
    public GameObject _GO_EndScreen;
    public Animator _EndScreen;
 
    [Header("Longueur des mots , LayoutGroup")]
   
    public int MaxLength;
    public GameObject ListContent;
    
    [HideInInspector] public string P_ChatBox;
    [HideInInspector] public int CurrentChar;
     
    int NbCorrectAnswer = 0;
   public  string _Answer;
    string _PlayerMsg;
    Countdown _Countdown;
    GameObject _MalusObj;
   
    Malo_Translator _translator;
 
    [Header("Canvas")]

    public GameObject UI_Telephone;
    public GameObject TextCanvas;

   [Header("Prefab Player_Bubble , Barre de Message")]
    public GameObject PlayerSpeechBubble;
    public Text TipBar;

    Text CurrentAnswer;
    Text PlayerText;

    GameObject PlayerChatBox;
    
  [Header("Prefab Malo_Bubble , MaloQuestion")]
    public GameObject MaloSpeechBubble;
    public Malo_Answer Question_1;
    public Malo_Answer Question_2;
    public Malo_Answer Question_3;
    GameObject MaloChatBox;
    public Animator ErrorTrigg;

    public GameObject ARWin;
   
    void Start()
    {
        StartCoroutine(WaitBeforeDisplay());
       
        if(NbCorrectAnswer == 0)
        {
            _Answer = Question_1.Expected_Answer;
            _translator.CurrentWord = Question_1.Question;
        }

        _MalusObj = GameObject.Find("Manager");
        _Countdown = _MalusObj.GetComponent<Countdown>();
    }

    void Update()
    {
        _PlayerMsg = P_ChatBox;
        TipBar.text = P_ChatBox;
    }
    public void DeleteString()
    {
        string Deleted = "";
        P_ChatBox = Deleted;
        CurrentChar = 0;
    }
    public void Send() // Quand le joueur a cliqué sur le bouton pour envoyer un message
    {

        if (TipBar.text == "173")
        {
            ARWin.SetActive(true);
           
            Debug.Log("WIN");
        }

            if (CurrentChar != 0)
        {
            SetupPlayer();
            string Deleted = "";
            // _PlayerMsg = Deleted;

            if(PlayerText.text == _Answer)
            {
                NbCorrectAnswer++;
            }
            else
            {
                ErrorTrigg.SetBool("Error", true);
                _Countdown.Malus();
            }
                P_ChatBox = Deleted;                               // efface le mot stocké 
                CurrentChar = 0;                                  // stuff pour ecrire
                TextCanvas.SetActive(true);                      // Change de canvas
                UI_Telephone.SetActive(false);
            if (NbCorrectAnswer == 1)
            {
                SetupMalo();
                _Answer = Question_2.Expected_Answer;
                _translator.CurrentWord = Question_2.Question;
                
            }

            if (NbCorrectAnswer == 2)
            {
                SetupMalo();
                _Answer = Question_3.Expected_Answer;
                _translator.CurrentWord = Question_3.Question;
               
            }
            if (NbCorrectAnswer == 3)
            {
                _GO_EndScreen.SetActive(true);
                _EndScreen.SetBool("FinalScreen", true);
            }
        }
    }
                
    public void OpenMenu()
    {
        UI_Telephone.SetActive(true);
        TextCanvas.SetActive(true);
    }
    void SetupPlayer()
    {
        PlayerChatBox = Instantiate(PlayerSpeechBubble, ListContent.transform);
    
        PlayerText = PlayerChatBox.GetComponentInChildren<Text>();
        PlayerText.text = _PlayerMsg;
    }

    void SetupMalo()
    {
       MaloChatBox =  Instantiate(MaloSpeechBubble, ListContent.transform);
        _translator = MaloChatBox.GetComponent<Malo_Translator>();
    }
    IEnumerator WaitBeforeDisplay()
    {   SetupMalo();
    
     yield return new WaitForSeconds(0.5f);
        
        if(NbCorrectAnswer == 0)
        {
            _Answer = Question_1.Expected_Answer;
            _translator.CurrentWord = Question_1.Question;
            Debug.Log(_translator.gameObject.name);
        }
    }

    public void ResetError()
    {
        ErrorTrigg.SetBool("IsError", false);
    }
}
