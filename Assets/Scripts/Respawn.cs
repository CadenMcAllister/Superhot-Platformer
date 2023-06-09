using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Enemy;
    public AIscript script;
    public bool Dead;
    GameObject EnemyClone;

    public void Update(){
        if (EnemyClone == null){
            Debug.LogError("EnemyClone is null");
        }
    }

    public void Respawn1(){
    EnemyClone = Instantiate(Enemy, new Vector3(0,0,0), Quaternion.identity);
    Enemy = EnemyClone;
    EnemyClone.SetActive(true);
    }

}
