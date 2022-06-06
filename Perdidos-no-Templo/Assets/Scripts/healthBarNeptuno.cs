using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarNeptuno : MonoBehaviour
{
    Image healthbar;
    float maxhealth = 10f;
    public static float health;
    public static bool dead;
    public static bool ganhou = false;
    // Start is called before the first frame update
    void Start()
    {
        dead = false;
        healthbar = GetComponent<Image>();
        health = maxhealth;
        healthbar.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = health / maxhealth;

        if (healthbar.fillAmount <= 0.50)
        {
            healthbar.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        if (healthbar.fillAmount == 0)
        {
            dead = true;
            Debug.Log("OVER");
        }
        if (NeptunoScript.numeroTridentes == 20 && healthbar.fillAmount != 0)
        {
            Debug.Log("Ganhou!");
            ganhou = true;

        }

        
    }
}
