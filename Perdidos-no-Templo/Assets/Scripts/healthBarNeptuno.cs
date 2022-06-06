using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarNeptuno : MonoBehaviour
{
    Image healthbar;
    float maxhealth = 10f;
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log("OVER");
        }
    }
}
