using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jupiter_Manager : MonoBehaviour
{
    public GameObject ImageInicio;
    public GameObject Pergunta1;
    public GameObject Pergunta2;
    public GameObject Pergunta3;
    public GameObject Pergunta4;
    public GameObject Pergunta5;
    public GameObject Pergunta6;
    public GameObject Pergunta7;
    public GameObject Errada1;
    public GameObject Errada2;
    public GameObject Errada3;
    public GameObject Errada4;
    public GameObject Errada5;
    public GameObject Errada6;
    public GameObject Errada7;
    public GameObject Pausa1;
    public GameObject Pausa2;
    public GameObject Pausa3;
    public GameObject Pausa4;
    public GameObject Pausa5;
    public GameObject Pausa6;
    public GameObject Pausa7;


    // Start is called before the first frame update
    public void Inicio()
    {
        ImageInicio.SetActive(false);
        Pergunta1.SetActive(true);
    }
    public void PrimeiraErrada(){
        Pergunta1.SetActive(false);
        Errada1.SetActive(true);
    }
    public void PrimeiraTentaAgain(){
        Pergunta1.SetActive(true);
        Errada1.SetActive(false);
    }
    public void PrimeiraSegunda(){
        Pergunta1.SetActive(false);
        Pausa1.SetActive(true);
    }
    public void SegundaPergunta(){
        Pausa1.SetActive(false);
        Pergunta2.SetActive(true);
    }
    public void SegundaErrada(){
        Pergunta2.SetActive(false);
        Errada2.SetActive(true);
    }
    public void SegundaTentaAgain(){
        Pergunta2.SetActive(true);
        Errada2.SetActive(false);
    }
    public void SegundaTerceira(){
        Pergunta2.SetActive(false);
        Pausa2.SetActive(true);
    }
    public void TerceiraPergunta(){
        Pausa2.SetActive(false);
        Pergunta3.SetActive(true);
    }
    public void TerceiraErrada(){
        Pergunta3.SetActive(false);
        Errada3.SetActive(true);
    }
    public void TerceiraTentaAgain(){
        Pergunta3.SetActive(true);
        Errada3.SetActive(false);
    }
    public void TerceiraQuarta(){
        Pergunta3.SetActive(false);
        Pausa3.SetActive(true);
    }
    public void QuartaPergunta(){
        Pausa3.SetActive(false);
        Pergunta4.SetActive(true);
    }
    public void QuartaErrada(){
        Pergunta4.SetActive(false);
        Errada4.SetActive(true);
    }
    public void QuartaTentaAgain(){
        Pergunta4.SetActive(true);
        Errada4.SetActive(false);
    }
    public void QuartaQuinta(){
        Pergunta4.SetActive(false);
        Pausa4.SetActive(true);
    }
    public void QuintaPergunta(){
        Pausa4.SetActive(false);
        Pergunta5.SetActive(true);
    }
    public void QuintaErrada(){
        Pergunta5.SetActive(false);
        Errada5.SetActive(true);
    }
    public void QuintaTentaAgain(){
        Pergunta5.SetActive(true);
        Errada5.SetActive(false);
    }
    public void QuintaSexta(){
        Pergunta5.SetActive(false);
        Pausa5.SetActive(true);
    }
    public void SextaPergunta(){
        Pausa5.SetActive(false);
        Pergunta6.SetActive(true);
    }
    public void SextaErrada(){
        Pergunta6.SetActive(false);
        Errada6.SetActive(true);
    }
    public void SextaTentaAgain(){
        Pergunta6.SetActive(true);
        Errada6.SetActive(false);
    }
    public void SextaSetima(){
        Pergunta6.SetActive(false);
        Pausa6.SetActive(true);
    }
    public void SetimaPergunta(){
        Pausa6.SetActive(false);
        Pergunta7.SetActive(true);
    }
    public void SetimaErrada(){
        Pergunta7.SetActive(false);
        Errada7.SetActive(true);
    }
    public void SetimaTentaAgain(){
        Pergunta7.SetActive(true);
        Errada7.SetActive(false);
    }
    public void SetimaFim(){
        Pergunta7.SetActive(false);
        Pausa7.SetActive(true);
    }

}
