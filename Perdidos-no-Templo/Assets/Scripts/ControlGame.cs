using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGame : MonoBehaviour
{

    public GameObject inicio;
    public GameObject jogo;
    public GameObject ganhar;
    public GameObject perder;
    void Start()
    {
        inicio.SetActive(true);
        jogo.SetActive(false);
        ganhar.SetActive(false);
        perder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBar.health <= 0)
        {
            inicio.SetActive(false);
            jogo.SetActive(false);
            ganhar.SetActive(false);
            perder.SetActive(true);
        }
        if (healthBar.health >= healthBar.maxhealth)
        {
            inicio.SetActive(false);
            jogo.SetActive(false);
            ganhar.SetActive(true);
            perder.SetActive(false);
            Debug.Log("VENCEU");
        }
    }

    public void StartGame()
    {
        inicio.SetActive(false);
        jogo.SetActive(true);
        ganhar.SetActive(false);
        perder.SetActive(false);
    }
}
