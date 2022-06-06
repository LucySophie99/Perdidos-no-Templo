using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class getCurrentSkin : MonoBehaviour
{
    public SpriteRenderer character;
    //public static int selectedSkin = 0;
    public List<Sprite> skins = new List<Sprite>();
    public Animator anim;
    public static int selectedIndex = 0;
  //  public GameObject skinM;


    private void Awake()
    {
      //  selectedIndex = skinManager.selectedSkin;
       
    }
  
    void Start()
    {
        

        character.sprite = skins[skinManager.selectedSkin];      
        Debug.Log(skinManager.selectedSkin);
        anim = character.GetComponent<Animator>();
        anim.enabled = false;
        
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            anim.enabled = true;
            if (skinManager.selectedSkin == 0)
            {
                anim.Play("girl_flecha",0,0);
                Debug.Log("Animação a funcionar");
                
            }

            if (skinManager.selectedSkin == 1)
            {
                anim.Play("boy_flecha",0,0);
                Debug.Log("Animação 2 a funcionar");
            }

        }

    }

     public void SetSelectedSkin()
     {
         // PrefabUtility.SaveAsPrefabAsset(playerSkin, "Assets/Sprites/selectedSkin.prefab");
         Debug.Log(skinManager.selectedSkin + "foi selecionado");
     }
}
