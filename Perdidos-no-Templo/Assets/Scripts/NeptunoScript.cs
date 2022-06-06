using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptunoScript : MonoBehaviour
{
    [SerializeField]

    GameObject tridente;
    float fireRate;
    float nextFire;

    private void Start()
    {
        fireRate = 1.8f;
        nextFire = Time.time;
    }
    private void Update()
    {
        CheckTimeOfFite();
    }

    public void CheckTimeOfFite()
    {
        if(Time.time > nextFire)
        {
            Instantiate(tridente, transform.position, Quaternion.identity); 
            nextFire = Time.time + fireRate;
        }
    }


    // Update is called once per frame


}
