using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skinManager : MonoBehaviour
{
    public SpriteRenderer character;
    public List<Sprite> skins = new List<Sprite>();
    public static int selectedSkin = 0;
    public GameObject playerSkin;
    
   
    public void NextSkin()
    {
        Debug.Log("clicou");
        selectedSkin = selectedSkin + 1;
        if(selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        character.sprite = skins[selectedSkin];
        Debug.Log(selectedSkin + "foi selecionado");
        

    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        SceneManager.LoadScene("Nivel4");
        Debug.Log(selectedSkin + "foi selecionado");
    }
}
