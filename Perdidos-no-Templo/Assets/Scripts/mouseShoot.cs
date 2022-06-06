using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseShoot : MonoBehaviour
{
    public GameObject flecha;
    public GameObject crosshairs;
    public GameObject character;
    private Vector3 mouse;
   // private Vector3 difference;
    public float velFlecha = 60.0f;
    public float delay = 0.05f;
    private float rotationZ;
    private Vector2 direction;
    
    

  
    // Update is called once per frame
    void Update()
    {
       mouse = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
       crosshairs.transform.position = new Vector2(mouse.x, mouse.y);
        Vector3 difference = mouse - character.transform.position;
        rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (Input.GetMouseButtonDown(0))
        {
            float distance = difference.magnitude;
            direction = difference / distance;
            direction.Normalize();
        
            Invoke("Disparar", 0);
        }
       
    }

    void Disparar()
    {
        dispararFlecha(direction, rotationZ);
    }


    void dispararFlecha(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(flecha) as GameObject;
        b.transform.position = character.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * velFlecha;
    }


}
