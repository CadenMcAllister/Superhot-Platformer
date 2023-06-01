using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public GameObject enemy; // reference to the enemy GameObject
    public GameObject gun; // reference to the gun GameObject
    public GameObject player; //reference to the player GameObject

    private void Update()
    {
        // get the enemy's position and add an offset to keep the gun above it
        Vector3 newPosition = enemy.transform.position + new Vector3(0, 1, 1);
        // set the gun's position to the new position
        gun.transform.localPosition = newPosition - gun.transform.parent.position;
        // rotate the gun towards the player
        Vector3 direction = player.transform.position - gun.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        gun.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
