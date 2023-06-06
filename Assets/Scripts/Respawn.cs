using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Enemy;
    public AIscript script;
    public bool Dead;
    GameObject EnemyClone;

    // Start is called before the first frame update
    public void Start()
    {
        EnemyClone = Instantiate(Enemy);
        bool Dead = script.Dead;
        
        if (Dead){
        Invoke("Respawn1", 2);
        }

    }

    void Respawn1(){
    }

}
