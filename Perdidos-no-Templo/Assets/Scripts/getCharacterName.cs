using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getCharacterName : MonoBehaviour
{
    
    public Text newName;
    
    void Start()
    {
        newName.text = keepCharacterName.nome;
        Debug.Log("NOME É" + newName);   
    }

  

   
}
