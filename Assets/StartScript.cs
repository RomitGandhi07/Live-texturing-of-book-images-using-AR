using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{

    

    void Awake(){
        Debug.Log("Awake Done...");
        // ClickObject clickObject = thePlayer.GetComponent<ClickObject>();
        // Debug.Log(clickObject.model);
        // Debug.Log(GameObject.FindGameObjectWithTag("Cube"));
    }

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(GameObject.FindGameObjectWithTag("Cube"));
        // Debug.Log(GameObject.Find("ClickVirtualButton"));
        // Debug.Log(GameObject.Find("ClickVirtualButton").GetComponent<ClickObject>().model);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
