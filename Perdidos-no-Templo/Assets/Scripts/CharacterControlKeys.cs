using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class CharacterControlKeys : MonoBehaviour
{
  private float movementSpeed = 10f;
    private Rigidbody2D rb;

    public SpriteRenderer character;
    //public static int selectedSkin = 0;
    public List<Sprite> skins = new List<Sprite>();
    public Animator anim;
    public static int selectedIndex = 0;

    // Start is called before the first frame update

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

        if(Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            anim.enabled = true;
            anim.Play("girl_running_right");
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            anim.enabled = true;
            anim.Play("girl_running_left");
            
        }

        // Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // if (Input.GetKeyDown(KeyCode.RightArrow))
        // rb.AddForce(Vector3.right * speed) ;
        // var move = Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        //transform.position = transform.position ++;

        //  gameObject.transform.position.x = gameObject.transform.position + 1;
        // if (Input.GetKeyDown(KeyCode.LeftArrow))
        //   rb.AddForce(Vector3.left);
    }
}
