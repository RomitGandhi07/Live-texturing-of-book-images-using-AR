using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class GoToHeart : MonoBehaviour , IVirtualButtonEventHandler
{
    public float model=100f;
     VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;

    void Start()
    {
        //Register with the virtual buttons TrackableBehaviour
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
 
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        // vbName = vb.VirtualButtonName;
        // Debug.Log("Name Is" + vbName);
            SceneManager.LoadScene("FinalHeart");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
 
    }

}
