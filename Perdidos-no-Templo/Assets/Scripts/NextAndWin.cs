using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAndWin : MonoBehaviour
{
    // Start is called before the first frame update
    private int pointsToWin;
    private int currentPoints;
    public GameObject myMatches;
    public GameObject matches;
    public GameObject myMatches2;
    public GameObject matches2;
    private bool fase1;
    void Start()
    {
       
        pointsToWin = myMatches.transform.childCount;
        fase1 = true;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (currentPoints >= pointsToWin)
        {
            
            if (fase1 == true)
            {
                myMatches.SetActive(false);
                matches.SetActive(false);
                fase1 = false;
                myMatches2.SetActive(true);
                matches2.SetActive(true);
                Debug.Log("Next Fase");
                currentPoints = 0;
                pointsToWin = myMatches2.transform.childCount;
            }

            if (fase1 == false)
            {
                
                Debug.Log("Game Over");
                
            }
        }
        
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
