using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyScript : MonoBehaviour
{

    protected Joystick joystick;
    protected Joybutton joybutton; 

    protected bool jump;

    // Start is called before the first frame update
    void Start()
    {
        joystick=FindObjectOfType<Joystick>();
        joybutton=FindObjectOfType<Joybutton>();

    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity= new Vector3(joystick.Horizontal * 5f ,
                                        rigidbody.velocity.y , 
                                        joystick.Vertical * 5f );
        
        if (!jump && joybutton.Pressed)
        {
            jump=true;
            rigidbody.velocity+= Vector3.up * 100f;
        }

        if (jump && !joybutton.Pressed)
        {
            jump=false;
        }
    }

}
