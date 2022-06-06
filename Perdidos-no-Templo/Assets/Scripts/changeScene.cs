using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class changeScene : MonoBehaviour
{
    public float delayTime = 3f;

    public void changeToScene2()
    {
        Invoke("Scene2", delayTime);
    }
    public void Scene2()
    {
        SceneManager.LoadScene("EscolherPersonagem");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Nivel4");
    }

}
