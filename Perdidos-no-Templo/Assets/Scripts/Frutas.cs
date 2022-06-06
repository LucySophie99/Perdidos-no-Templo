using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frutas : MonoBehaviour
{
    public GameObject[] frutas;
    public GameObject fogo;
    public float xBound, xBound2, yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomFruit = Random.Range(0, frutas.Length);

        if (Random.value <= .6f)
        {
            Instantiate(frutas[randomFruit], new Vector2(Random.Range(xBound2, xBound), yBound), Quaternion.identity);
        }
        else
        {
            Instantiate(fogo, new Vector2(Random.Range(xBound2, xBound), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomGameObject());
    }
   
}
