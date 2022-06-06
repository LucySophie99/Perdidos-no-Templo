using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    Image healthbar;
    public static float maxhealth = 100f;
    public static float health;

  

    void Start()
    {
        healthbar = GetComponent<Image>();
        health = maxhealth /2;
   
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = health / maxhealth;

        
    }

   

   
        

}
