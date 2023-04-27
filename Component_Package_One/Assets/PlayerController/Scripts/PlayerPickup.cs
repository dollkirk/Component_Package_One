using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform pickupDestination;
    private bool mouseDown;
    public PlayerThrow throwScript;

    void Start()
    {
        mouseDown = false;
    }

    void Update()
    {
        //Checking if the left mouse button is held down.
        if (mouseDown)
        {
            //Accessing the Rigidbody component of the attached game object. In this case, the throwable object.
            //Switching off the gravity of the Rigidbody.
            GetComponent<Rigidbody>().useGravity = false;

            //Setting the throwable object's transfrom position to the pickup destination that is set in the Unity editor.
            this.transform.position = pickupDestination.position;

            //Setting the throwable object's parent as the gameobject in the Unity scene called "Destination".
            this.transform.parent = GameObject.Find("Destination").transform;
        }
        else if (!mouseDown)
        {
            //Setting the throwable object's parent as nothing. This is because, when it throws, it shouldn't be a child of "Destination" anymore.
            this.transform.parent = null;
            //Reactivating the throwable object's Rigidbody gravity.
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

    void OnMouseDown()
    {
        mouseDown = true;
    }

    public void OnMouseUp()
    {
        mouseDown = false;

        //Calling the Throw() function in the "PlayerThrow" script.
        throwScript.Throw();
    }
}
