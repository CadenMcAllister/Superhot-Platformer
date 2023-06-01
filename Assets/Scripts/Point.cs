using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Transform spriteTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }


void Update()
{
    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mousePos.z = 0f;
    Vector3 direction = mousePos - spriteTransform.position;
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    spriteTransform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
}

}
