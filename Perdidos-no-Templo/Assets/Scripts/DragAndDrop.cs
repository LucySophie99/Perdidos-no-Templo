using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler , IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    // Start is called before the first frame update
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public EventSystem mySystem;
    public List<Image> descricao;
    public List<Image> trabalho;
    private GameObject lastSelectedObject;


    private void Start()
    {
        
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>(); 
    }

    
    public void OnBeginDrag(PointerEventData eventData)
    {
      
        Debug.Log("Drag On");
        canvasGroup.alpha = .6f;  
        canvasGroup.blocksRaycasts = false;
    }


    public void OnDrag(PointerEventData eventData)
    {
       
        Debug.Log("Drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
  

   
    public void OnEndDrag(PointerEventData eventData)
    {
       
        Debug.Log("Drag Off");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        Debug.Log("Pointer down");
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void CheckMatch()
    {

        if (lastSelectedObject == null)
            lastSelectedObject = mySystem.currentSelectedGameObject;
        Debug.Log("Select & Checking Match..");


        if (mySystem.currentSelectedGameObject != lastSelectedObject)
        {
            if (mySystem.currentSelectedGameObject.name == lastSelectedObject.name)
            {

                Debug.Log("Image Match !");
                UpdateBoardAfterSuccess();

            }
            else
            {

                Debug.Log("Images Not Matching");
                ResetBuffers();

            }

        }

    }
    void UpdateBoardAfterSuccess()
    {

        // I brutaly set the whole gameObject to unActive but you could just disable the image component
        lastSelectedObject.SetActive(false);
        mySystem.currentSelectedGameObject.SetActive(false);
        ResetBuffers();

    }

    void ResetBuffers()
    {

        lastSelectedObject = null;
        mySystem.SetSelectedGameObject(null);

    }


}
