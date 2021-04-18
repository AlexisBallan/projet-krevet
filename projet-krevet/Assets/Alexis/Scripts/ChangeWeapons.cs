using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapons : MonoBehaviour
{
    private GameObject ActualWeapon;


    private void Awake()
    {
        ActualWeapon = null;
    }

    public void ChangeWeapon(GameObject NewWeapon)
    {
        DestroyImmediate(ActualWeapon);
        ActualWeapon = NewWeapon;
        Instantiate(ActualWeapon);
    }

}
