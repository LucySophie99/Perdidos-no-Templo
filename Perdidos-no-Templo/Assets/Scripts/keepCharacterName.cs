using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepCharacterName : MonoBehaviour
{
    public static string nome;
    public Text inputField;
    public GameObject textDisplay;
    public GameObject playerName;


    // Start is called before the first frame update
    void Start()
    {
      textDisplay.SetActive(false);
    }

    // Update is called once per frame
    public void StoreName()
    {
        nome = inputField.GetComponent<Text>().text;
        textDisplay.SetActive(true);
        textDisplay.GetComponent<Text>().text = nome;
    }
    public void SaveUsername()
    {    
       // inputField.text = inputField.text.ToString(); // All that's happening here is you're setting text as the exact same text that it already has.
      PlayerPrefs.SetString(nome, inputField.text);

    }

    public void LoadName()
    {
        if (PlayerPrefs.HasKey(nome))
        {
            inputField.text = PlayerPrefs.GetString(nome);
            Debug.Log(nome + "foi  gravado");        }
        else
        {
            Debug.Log("Username not saved yet");
        }
    }
}
