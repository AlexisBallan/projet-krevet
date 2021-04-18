using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private ChangeWeapons ChangeWeapon;

    public GameObject WeaponChange;


    public void WeaponToChange()
    {
        ChangeWeapon.ChangeWeapon(WeaponChange);
    }

}
