using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercurio_DinamicaJogo : MonoBehaviour
{
    [SerializeField]
    private Transform PairsField;

    [SerializeField]
    private GameObject btn;

    public GameObject Jogo;
    public GameObject StartPanel;

    void Awake (){
        for(int i=0; i<12; i++){
            GameObject button = Instantiate(btn);
            button.name = ""+ i;
            button.transform.SetParent(PairsField, false);
        }
    }

    
}
