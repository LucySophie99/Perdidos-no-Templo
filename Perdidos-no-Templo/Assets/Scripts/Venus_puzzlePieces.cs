using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Venus_puzzlePieces : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool inRightPosition;
    public bool Selected;
    
    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(-7f, 5f), Random.Range(-2f,-4f), -1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, RightPosition) < 1.0f){
            if(!Selected){
                if(inRightPosition == false){


            transform.position = RightPosition;
            inRightPosition = true;
            GetComponent<SortingGroup>().sortingOrder = 0;
            Camera.main.GetComponent<Venus_dragndrop>().PlacedPieces++;
            }
            }
        }
    }



    
}
