using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapons : MonoBehaviour
{
    public GameObject ActualWeapon;
    public GameObject Player;

    private void Awake()
    {
        
    }

    public void ChangeWeapon(GameObject NewWeapon)
    {
        DestroyImmediate(ActualWeapon);
        ActualWeapon = NewWeapon;
        Instantiate(ActualWeapon);
    }
}
