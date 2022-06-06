using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class CharacterControlKeys : MonoBehaviour
{
  
    private float movementSpeed = 20f;
    private Rigidbody2D rb;

    public SpriteRenderer character; 
    public List<Sprite> skins = new List<Sprite>();
    public Animator anim;
    public static int selectedIndex = 0;



    private void Start()
    {
        character.sprite = skins[skinManager.selectedSkin];
        Debug.Log(skinManager.selectedSkin);
        anim = character.GetComponent<Animator>();
        anim.enabled = false;
        // rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        character.transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

       if(skinManager.selectedSkin == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) == true)
            {
                anim.enabled = true;
                anim.Play("girl_running_right");

            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
            {
                anim.enabled = true;
                anim.Play("girl_running_left");

            }
        }
       if(skinManager.selectedSkin == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) == true)
            {
                anim.enabled = true;
                anim.Play("ght_ruuning_right");

            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
            {
                anim.enabled = true;
                anim.Play("boy_running_left");

            }

        }

        }


    }

