using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter2D(Collision2D collision){
    if (collision.gameObject.tag == "cube" | collision.gameObject.tag == "Player" | collision.gameObject.tag == "Ground" | collision.gameObject.tag == "Projectile"){
        Destroy(gameObject);
    }
}

}
