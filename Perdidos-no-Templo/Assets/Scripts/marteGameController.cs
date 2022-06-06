using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class marteGameController : MonoBehaviour
{



    //public Text scoreText;
  //  public static int score = 0;
    public Collider2D relva;



     void Start()
    {
    }

    void Update()
    {

     

    }

     void OnTriggerEnter2D(Collider2D target)
    {
        if (this.tag == "fruta")
        {
            Debug.Log("fruta");
    
        }

        if (this.tag == "fogo" && target.tag == "flecha")
        {
         
            healthBar.health += 5f;
            
        }

        if (target.tag == "relva" && this.tag == "fogo")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            healthBar.health -= 5f;


        }

        if (target.tag == "flecha" && this.tag == "fruta")
        {

            healthBar.health -= 1f;

        }

    }

    void OnTriggerExit2D(Collider2D target)
    {
        Destroy(this.gameObject);
       
        //Debug.Log(score);
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }
  
}
