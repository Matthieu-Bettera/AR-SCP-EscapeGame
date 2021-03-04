using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Malo_Translator : MonoBehaviour
{
   
    public Text _text;
    int wordIndex;
    int AlphabetIndex;
    int NumberIndex;
    [Header(" A remplir")]
    public string CurrentWord;
   string Translated;

     List<char> characters = new List<char>();

    [Header(" Debug")]

  
    [Space]
    public List<string> numberlist = new List<string>();
    [Space]
     public List<char> Alphabet = new List<char>();
    void Start()
    {
        numberlist.Reverse();

        for (int i = 0; i < CurrentWord.Length; i++) // tant que i < nombre de lettres totales , i++
        {

            characters.Add(CurrentWord[i]); // 
        }
    }
        // Update is called once per frame
        void Update()
        {
        TranslateToNumber();
           
        }
        

   
        private void TranslateToNumber()
{
    if (wordIndex < CurrentWord.Length)
    {
        if (CurrentWord[wordIndex] == Alphabet[AlphabetIndex])
        {
            NumberIndex = AlphabetIndex;
            Translated = Translated + "-" + numberlist[NumberIndex];
            _text.text = Translated;
            AlphabetIndex = 0;
            wordIndex++;
        }
        else AlphabetIndex++;
    }
}
}

