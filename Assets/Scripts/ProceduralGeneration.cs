using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProceduralGeneration : MonoBehaviour
{

    public bool called = false;
    public bool Spawn = false;
    public GameObject Platform;
    public float heightOffset = 10;
    public float widthOffset = 10;

    public void SpawnPlatform()
    {
        called = true;
        //The lowest point the pipe can be spawned is equal to the y position - the height offset. The height offset is added for the highest point.
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float furtherstPoint = transform.position.x - widthOffset;
        float closestPoint = transform.position.x + widthOffset;
//Creates a new pipe at the x position already given and at any y position between lowestPoint and highestPoint, keeping roatation the same as the parent object.
        Instantiate(Platform, new Vector3(Random.Range(furtherstPoint, closestPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Instantiate(Platform, new Vector3(Random.Range(furtherstPoint, closestPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Instantiate(Platform, new Vector3(Random.Range(furtherstPoint, closestPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Instantiate(Platform, new Vector3(Random.Range(furtherstPoint, closestPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

    void Update(){
        if(called == true){
            Spawn = true;
        }
    }
}