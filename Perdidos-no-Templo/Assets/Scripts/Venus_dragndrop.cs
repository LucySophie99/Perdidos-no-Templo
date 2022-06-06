using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Venus_dragndrop : MonoBehaviour
{
    public GameObject SelectedPiece;
    int OIL = 1;
    public GameObject StartPanel;
    public GameObject ImageEnd;
    public GameObject Jogo;
    public int PlacedPieces = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlacedPieces);
        if(Input.GetMouseButtonDown(0)){
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if(hit.transform.CompareTag("Puzzle")){
                if(!hit.transform.GetComponent<Venus_puzzlePieces>().inRightPosition){
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<Venus_puzzlePieces>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                    

                }
            }
        }
        if(Input.GetMouseButtonUp(0)){
            if(SelectedPiece != null){
            SelectedPiece.GetComponent<Venus_puzzlePieces>().Selected = false;
            SelectedPiece = null;
            
            }
           

        }
        if(SelectedPiece != null){
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, -1);
            
    }
    if(PlacedPieces == 40){
        Jogo.SetActive(false);
        ImageEnd.SetActive(true);
    }
    }
    public void Inicio(){
        StartPanel.SetActive(false);
        Jogo.SetActive(true);


}

}
