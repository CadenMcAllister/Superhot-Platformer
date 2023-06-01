
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class weaponScript : MonoBehaviour
{
int totalWeapons = 1;
public int currentWeaponIndex;


public GameObject[] guns;
public GameObject weaponHolder;
public GameObject currentGun;


// Start is called before the first frame update
void Start()
{
totalWeapons = weaponHolder.transform.childCount;
guns = new GameObject[totalWeapons];


for (int i = 0; i < totalWeapons; i++)
{
guns[i] = weaponHolder.transform.GetChild(i).gameObject;
guns[i].SetActive(false);
}

guns[0].SetActive(true);
currentGun = guns[0];
currentWeaponIndex = 0;

}


// Update is called once per frame
void Update()
{
if (Input.GetKeyDown(KeyCode.E))
{
if (currentWeaponIndex < totalWeapons - 1)
{
guns[currentWeaponIndex].SetActive(false);
currentWeaponIndex++;
if (currentWeaponIndex >= totalWeapons)
{
currentWeaponIndex = 0;
}
guns[currentWeaponIndex].SetActive(true);
}
}


if (Input.GetKeyDown(KeyCode.Q))
{
    if (currentWeaponIndex >= 0)
    {
        guns[currentWeaponIndex].SetActive(false);
        currentWeaponIndex--;
        if (currentWeaponIndex <= -1)
        {
            currentWeaponIndex = totalWeapons - 1;
        }
        guns[currentWeaponIndex].SetActive(true);
    }
}

if (currentWeaponIndex < 0 || currentWeaponIndex >= totalWeapons)
{
    currentWeaponIndex = 0;
}

}
}

