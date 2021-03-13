using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Malo_Translator : MonoBehaviour
{
   
     Text Malo_Text;
    int TranslatedLength;
    int wordIndex;
    int AlphabetIndex;
    int NumberIndex;
    [Header(" A remplir")]
    public string CurrentWord;
  public string Translated;

    public List<char> characters = new List<char>();

    [Header(" Debug")]

  
    [Space]
    public List<string> numberlist = new List<string>();
    [Space]
     public List<char> Alphabet = new List<char>();
    void Start()
    {
        StartCoroutine(WaitBeforeDisplay());
        
      
        
    }
       
    void Update()
    {
         
             TranslateToNumber();
       
    }
        

   
   private void TranslateToNumber() // traduit
{
         if (wordIndex < CurrentWord.Length)
         {
              if (CurrentWord[wordIndex] == Alphabet[AlphabetIndex])
              {
                   NumberIndex = AlphabetIndex;
                   Translated =  Translated +  numberlist[NumberIndex]+ "-";
                
                TranslatedLength++;
                Malo_Text = gameObject.GetComponentInChildren<Text>();
                   Malo_Text.text = Translated.Substring(0, Translated.Length - 1); ;
                   AlphabetIndex = 0;
                   wordIndex++;
              }
                 else AlphabetIndex++;
    }
}
    IEnumerator WaitBeforeDisplay()
    {
        yield return new WaitForSeconds(2f);
        numberlist.Reverse();

        for (int i = 0; i < CurrentWord.Length; i++) // tant que i < nombre de lettres totales , i++
        {

            characters.Add(CurrentWord[i]); // 
        }
    }
   
}

