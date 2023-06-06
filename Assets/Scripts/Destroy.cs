using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Destroy : MonoBehaviour
{
    ProceduralGeneration gen;

    public bool Spawn = false;
    public string targetTag = "Ground";

    private List<GameObject> objectsWithTag;

    // Start is called before the first frame update
    public void Start()
    {
        gen = GetComponent<ProceduralGeneration>();
        if (gen == null)
        {
            Debug.LogError("ProceduralGeneration script not found on the same GameObject.");
            return;
        }

        Spawn = gen.Spawn;
        objectsWithTag = GameObject.FindGameObjectsWithTag(targetTag).ToList();

        if (objectsWithTag.Count < 3)
        {
            Debug.Log("Not enough objects with tag " + targetTag);
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if (objectsWithTag.Count > 4)
        {
            for (int i = 0; i < 1; i++)
            {
                if (objectsWithTag.Count == 0)
                    break;

                int randomIndex = Random.Range(0, objectsWithTag.Count);
                Destroy(objectsWithTag[randomIndex]);
                objectsWithTag.RemoveAt(randomIndex);
            }
        }
    }
}
