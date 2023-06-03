using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletObject;
    public GameObject ExplosionObject;
    public AudioSource ExplosionAudioSource;
    public AudioClip ExplosionAudioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

private void OnCollisionEnter2D(Collision2D collision){
    if (collision.gameObject.tag == "cube" | collision.gameObject.tag == "Player" | collision.gameObject.tag == "Ground" | collision.gameObject.tag == "Projectile"){
        ExplosionAudioSource.Play();
        Instantiate(ExplosionObject, transform.position, transform.rotation);
        Invoke("Explosion", 1);
    }
}



    public void Explosion(){
        Destroy(gameObject);
    }
}
