using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeptunoScript : MonoBehaviour
{
    [SerializeField]

    GameObject tridente;
    float fireRate;
    float nextFire;
    public static int numeroTridentes = 1;
    public Text totalTridentes;
    static int numeroAtualTridentes = 20;

    private void Start()
    {
        fireRate = 1.8f;
        nextFire = Time.time;
    }
    private void Update()
    {
        CheckTimeOfFite();

       totalTridentes.text = numeroAtualTridentes.ToString();
    }

    public void CheckTimeOfFite()
    {
        if(Time.time > nextFire)
        {
            Instantiate(tridente, transform.position, Quaternion.identity); 
            nextFire = Time.time + fireRate;

            numeroTridentes++;
            numeroAtualTridentes--;
        }
    }


    // Update is called once per frame


}
