using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwappingArray : MonoBehaviour
{
    public Sprite[] weapons; // Array of weapon sprites

    private GameObject currentWeapon; // Reference to the current active weapon GameObject
    private SpriteRenderer currentWeaponSpriteRenderer; // Reference to the Sprite Renderer component of the current active weapon GameObject

    void Start()
    {
        currentWeapon = transform.GetChild(0).gameObject; // Get the first child GameObject (assuming there's only one child) as the current active weapon
        currentWeaponSpriteRenderer = currentWeapon.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Check for number keys 1-9
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0 + i))
            {
                // Check if weapon sprite exists in the array
                if (i - 1 < weapons.Length)
                {
                    // Change the sprite of the current active weapon
                    currentWeaponSpriteRenderer.sprite = weapons[i - 1];
                }
            }
        }
    }
}
