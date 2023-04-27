# Component Package One - 3D Player Controller

## Behaviours
PlayerController

PlayerPickup

PlayerThrow

## PlayerController
This script is the main movement controller for the player object. It takes the inputs of WASD for left, right, forwards and backwards, and SPACE for jump/ double jump. 

For the WASD movements, it also applies a Quarternion rotation to the player object in the direction of what the player object is facing.

The variables that can be edited for desired outcome are "moveSpeed" (speed in which the player object moves when inputted), "rotationSpeed" (speed in which the player object rotates in the direction of movement), "jumpForce" (the force that is applied to the player object to create a jump), "airMultiplier" (the extra force that is applied to the movement when jumping to create a floaty effect), "checkGroundDistance" (the distance between the player object and ground. Varies when the player object is a different shape or is in different dimensions) and "ground" (the gameobjects that have the selected layer. In this case, it would be the layer "Ground").

## PlayerPickup
This script is for picking up "throwable" objects. It takes the input of LEFT MOUSE DOWN for picking up.

When inputted to pickup, the throwable object's Rigidbody will be accessed and the gravity will be switched off. The throwable object's position will then move to where the destination point is and will become a child of that point. When the input is released, the throwable objects gravity will switch back on and it will stop being a child the destination point. The "PlayerThrow" script is then called to access the "Throw()" function as this will apply the force to throw the throwable object.

The variables that can be edited for desired outcome are "pickupDestination" (the transform of the empty game object that the throwable object will move to) and "PlayerThrow" (the script access for "PlayerThrow").

## PlayerThrow
This script is for throwing the "throwable" objects. This script takes no player inputs as it is called in the "PlayerPickup" script for when the player releases the LEFT MOUSE DOWN.

The function "Throw()" is called in the "PlayerPickup" script. This function creates a forward and upward force in to direction of the player object's rotation. it then applies this created force to the throw object's Rigidbody.

The variables that can be edited for desired outcome are "playerRotation" (the transform of the player object), "throwForce" (the forward force of the throw) and "throwUpwardForce" (the upward force of the throw).