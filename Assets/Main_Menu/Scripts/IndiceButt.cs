using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndiceButt : MonoBehaviour
{
    public int _index = -1;
    public bool _StartBool = true;
    public string _TextIndice;
    public bool _MalOOpen;
    public bool _MalORes;
    public bool _SCP682;
    public bool _SCP682Res;
    Text _IndiceText;
    GameObject _IndiceGo;
    GameObject _RevoirIndiceGo;
    Text _RevoirIndiceText;

    public void Indices()
    {
        _IndiceGo = GameObject.Find("IndiceText");
        _IndiceText = _IndiceGo.GetComponent<Text>();

        if(_StartBool)
        {
            
            _MalOOpen = false;
            _MalORes = false;
            _SCP682 = false;
            _SCP682Res =false;
            IncreaseIndex();
            NoEngine();
        }
        if(_MalOOpen)
        {
            _StartBool = false;
            _MalORes = false;
            _SCP682 = false;
            _SCP682Res =false;
            IncreaseIndex();
            MalOwOpen();
        }
        if(_MalORes)
        {
            _MalOOpen = false;
            _StartBool = false;
            _SCP682 = false;
            _SCP682Res =false;
            IncreaseIndex();
            MalOwRes();
        }
        if(_SCP682)
        {
            _MalOOpen = false;
            _MalORes = false;
            _StartBool = false;
            _SCP682Res =false;
            IncreaseIndex();
            SCP682();
        }
        if(_SCP682Res)
        {
            _MalOOpen = false;
            _MalORes = false;
            _SCP682 = false;
            _StartBool =false;
            IncreaseIndex();
            SCP682Res();
        }
        _IndiceText.text = _TextIndice;
    }

    public void RevoirIndice()
    {
        _RevoirIndiceGo = GameObject.Find("RevoirIndiceText");
        _RevoirIndiceText = _RevoirIndiceGo.GetComponent<Text>();
        _RevoirIndiceText.text = _TextIndice;
    }

    void Start()
    {
        _index = -1;
    }
    public void IncreaseIndex()
    {
        _index++;
    }

    void NoEngine()
    {
        if(_StartBool)
        {
            if(_index == 0)
            {
                _TextIndice = "Un chiffre est caché quelque part.";
            }
            if(_index == 1)
            {
                _TextIndice = "Avez-vous en votre possession une clé qui pourrait être améliorée ?";
            }
            if(_index == 2)
            {
                _TextIndice = "Mettez la carte Pass dans la partie droite de SCP-914.";
            }
            if(_index == 3)
            {
                _index = -1;
                _StartBool = false;
            }
        }
    }
    void MalOwOpen()
    {
        if(_MalOOpen)
        {
            if(_index == 0)
            {
                _TextIndice = "Chaque nombre correspond à une lettre. Le tout est de savoir à quelle lettre correspond quel nombre.";
            }
            if(_index == 1)
            {
                _TextIndice = "Dans les codes par chiffrement ordinaires, le 1 correspond souvent au A. Mais SCP-1471 a tendance à faire les choses à l'envers...";
            }
            if(_index == 2)
            {
                _TextIndice = "Écrivez sur le portable en suivant la manière de parler de SCP-1471. Le chiffre 1 correspond à Z, 2 à Y, et ainsi de suite.";
            }
            if(_index == 3)
            {
                _index = -1;
                _MalOOpen = false;  
            }
        }
    }
    void MalOwRes()
    {
        if(_MalORes)
        {
            if(_index == 0)
            {
                _TextIndice = "La porte de droite du grand hall est recouverte d'une espèce de chair informe. Il faudrait un produit chimique pour faire fondre l'obstacle...";
            }
            if(_index == 1)
            {
                _TextIndice = "Il y a un plan de travail dans le laboratoire. Et la chimie est une affaire de mélange de couleurs, en un sens.";
            }
            if(_index == 2)
            {
                _TextIndice = "Mélangez les fioles en suivant leur forme et leur couleur de manière à former l'acide de référence du plan de travail. Les chiffres des deux fioles correspondantes mis bout à bout donnent le nombre de la carte à piocher.";
            }
            if(_index == 3)
            {
                _index = -1;
                _MalORes = false;
            }
        }
    }
    void SCP682()
    {
        if(_SCP682)
        {
            if(_index == 0)
            {
                _TextIndice = "SCP-682 est un monstre coriace. Les scientifiques ont dû documenter la manière de s'y prendre avec lui quelque part...";
            }
            if(_index == 1)
            {
                _TextIndice = "Un rapport SCP traîne dans la salle de contrôle. Lisez attentivement le dernier paragraphe.";
            }
            if(_index == 2)
            {
                _index = -1;
                _SCP682 = false;
            }
        }
    }
    void SCP682Res()
    {
        if(_SCP682Res)
        {
            if(_index == 0)
            {
                _TextIndice = "Le code est en plusieurs parties. Chaque partie peut être trouvée dans trois énigmes différentes.";
            }
            if(_index == 1)
            {
                _TextIndice = "Souvenez-vous du chiffre donné par SCP-682. Essayez de voir au-delà de la censure. Comptez les morts.";
            }
            if(_index == 2)
            {
                _TextIndice = "Chaque symbole rouge symbolise une partie du code. L'ordre correct dans lequel ces morceaux doivent être agencés est indiqué sur la bonne photo de SCP-173. Une description de l'objet traîne sur le sol du hall.";
            }
            if(_index == 3)
            {
                _index = -1;
                _SCP682Res = false;
            }
        }
    }
}
