using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    [Header("References")]
    public Transform playerRotation;

    [Header("Throwing")]
    public float throwForce;
    public float throwUpwardForce;

    //This "Throw()" function is called in the "PlayerPickup" script.
    public void Throw()
    {
        //Checking if it can access the rigidbody of the thrown object.
        if (TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            //Setting the thrown object's Rigibody kinematic to false.
            rb.isKinematic = false;

            //Creating force to the thrown object in the direction of the player object's rotation, and up to create that throw effect.
            Vector3 forceToAdd = (playerRotation.transform.forward * throwForce) + (rb.transform.up * throwUpwardForce);

            //Applying that created force to the thrown object's Rigidbody.
            rb.AddForce(forceToAdd, ForceMode.Impulse);
        }
    }

    
}
