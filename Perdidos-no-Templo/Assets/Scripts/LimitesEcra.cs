using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitesEcra : MonoBehaviour
{
    public Camera MainCamera;
    private Vector2 screenLimits;
    private float objWidth;
    private float objHeight;    
    void Start()
    {
        screenLimits = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        objWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        objHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenLimits.x * -1 + objWidth, screenLimits.x - objWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenLimits.y * -1 + objHeight, screenLimits.y  - objHeight);
        transform.position = viewPos;
    }
}
