using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio_Manager : MonoBehaviour
{
    public GameObject ImageInicio;
    public GameObject ImageMeio;
    public GameObject ImageFim;
    // Start is called before the first frame update
    public void Meio(){
        ImageInicio.SetActive(false);
        ImageMeio.SetActive(true);
    }
    public void Fim(){
        ImageMeio.SetActive(false);
        ImageFim.SetActive(true);
    }
}
