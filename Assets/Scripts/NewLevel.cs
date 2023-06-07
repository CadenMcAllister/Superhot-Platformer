using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevel : MonoBehaviour
{
    public GameObject newLevelScreen;
    public AIscript script;
    public GameObject Enemy;
    public bool Dead;

    
    // Start is called before the first frame update
    void Start()
    {
        newLevelScreen.SetActive(false);

        bool Dead = script.Dead;
    }

    public void Deactivate(){
        newLevelScreen.SetActive(false);
    }

    public void NewLevel1(){
        newLevelScreen.SetActive(true);
        Invoke("Deactivate", 5);
    }


}
