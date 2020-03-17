using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour , IPointerUpHandler , IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData){
        Pressed=true;
    }

    public void OnPointerUp(PointerEventData eventData){
        Pressed=false;
    }
}
