using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class changeScene : MonoBehaviour
{
    public float delayTime = 3f;


    public void Scene1()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("EscolherPersonagem");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Mercurio");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Neptuno");
    }
    public void LoadSceneMarte()
    {
        SceneManager.LoadScene("Marte");
    }

    public void Scene5()
    {
        SceneManager.LoadScene("Venus");
    }

    public void Scene6()
    {
        SceneManager.LoadScene("Minerva");
    }

    public void Scene7()
    {
        SceneManager.LoadScene("Juno");
    }
    public void Scene8()
    {
        SceneManager.LoadScene("Jupiter");
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void LoadFim()
    {
        SceneManager.LoadScene("Fim");
    }
    public void LoadEmblemas()
    {
        SceneManager.LoadScene("Emblemas");
    }
}
