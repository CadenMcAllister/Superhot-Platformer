using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // reference to the player GameObject
    public GameObject gun; // reference to the gun GameObject
    public Transform gunOrientation; // reference to the object controlling the gun orientation

private void Update()
{
    // get the player's position and add an offset to keep the gun above it
Vector3 newPosition = player.transform.position + new Vector3(0, 1, 1);
    // set the sprite's position to the new position
transform.localPosition = newPosition - transform.parent.position;
    // make the gun always face the gunOrientation object
Vector3 directionToLook = gunOrientation.position - gun.transform.position;
Quaternion rotationToLook = Quaternion.LookRotation(directionToLook, Vector3.up);
gun.transform.localRotation = rotationToLook;
}

}
