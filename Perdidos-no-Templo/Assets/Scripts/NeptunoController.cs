using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NeptunoController : MonoBehaviour
{
    public GameObject ecraInicial;
    public GameObject ecraFinal;
    public GameObject ecraFinalPerder;
    public GameObject jogo;

    void Start()
    {
        ecraInicial.SetActive(true);
        jogo.SetActive(false);
       // spawner.SetActive(false);
        ecraFinal.SetActive(false);
       // neptuno.SetActive(false);
        ecraFinalPerder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBarNeptuno.ganhou == true)
        {
            EndGame();
        }

        if (healthBarNeptuno.dead == true)
        {
            EndGameLoose();
        }
    }

    public void StartGame()
    {
        ecraInicial.SetActive(false);
       // neptuno.SetActive(true);
        jogo.SetActive(true);
       // spawner.SetActive(true);
        ecraFinal.SetActive(false);
        ecraFinalPerder.SetActive(false);
    }

    public void EndGame()
    {
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ecraInicial.SetActive(false);
        //neptuno.SetActive(false);
        jogo.SetActive(false);
       // spawner.SetActive(false);
         ecraFinal.SetActive(true);
        ecraFinalPerder.SetActive(false);
    }
    public void EndGameLoose()
    {
       
        ecraInicial.SetActive(false);
      //  neptuno.SetActive(false);
        jogo.SetActive(false);
       // spawner.SetActive(false);
        ecraFinal.SetActive(false);
        ecraFinalPerder.SetActive(true);
    }
    public void reloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }




}
