using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextAndWin : MonoBehaviour
{

    public GameObject jogo;
    public GameObject ecraInicial;
    public GameObject ecraFinal;
    private int pointsToWin;
    private int currentPoints;
    public GameObject myMatches;
    public GameObject matches;
    public GameObject myMatches2;
    public GameObject matches2;
    public bool fase1;

    public AudioClip firstAudio;
    public AudioClip secondAudio;
    public AudioSource audioSource;
  
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
     
        ecraInicial.SetActive(true);
        jogo.SetActive(false);
        ecraFinal.SetActive(false);

        pointsToWin = myMatches.transform.childCount;
        fase1 = true;

  
    }

 
    void Update()
    {
       
        
        if (currentPoints >= pointsToWin && fase1 == true)
        {
            audioSource.clip = firstAudio;
            audioSource.Play();

          
            Debug.Log("Ainda fase 1");
                myMatches.SetActive(false);
                matches.SetActive(false);
                myMatches2.SetActive(true);
                matches2.SetActive(true);
                Debug.Log("Next Fase");
                currentPoints = 0;
                pointsToWin = myMatches2.transform.childCount;
            fase1 = false;

        }

        if (fase1 == false && currentPoints >= pointsToWin)
        {
            Debug.Log("Game Over");
         
            audioSource.clip = secondAudio;
            audioSource.PlayOneShot(secondAudio);

            jogo.SetActive(false);
            ecraFinal.SetActive(true);
        }

    }
    public void startGame()
    {
        ecraInicial.SetActive(false);
        jogo.SetActive(true);
    }

    public void loadNextScene()
    {
        SceneManager.LoadScene("Jupiter");
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
