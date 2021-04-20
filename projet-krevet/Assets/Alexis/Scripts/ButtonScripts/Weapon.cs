using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private ChangeWeapons ChangeWeapon;

    public GameObject Player;
    public GameObject WeaponChange;

    private void Start()
    {
        ChangeWeapon = Player.GetComponent<ChangeWeapons>();
    }

  

    public void WeaponToChange()
    {
        ChangeWeapon.ChangeWeapon(WeaponChange);
    }

}
