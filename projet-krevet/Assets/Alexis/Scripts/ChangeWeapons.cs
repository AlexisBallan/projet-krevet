using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapons : MonoBehaviour
{
    public GameObject ActualWeapon;
    public GameObject Player;

    private bool _CanChange;

    private void Awake()
    {
        
    }

    public void ChangeWeapon(GameObject NewWeapon)
    {
        if (ActualWeapon == NewWeapon)
            return;
        else
        {
            DestroyImmediate(ActualWeapon.gameObject);
            _CanChange = true;
            ActualWeapon= NewWeapon;

           // Player = Instantiate(ActualWeapon) as GameObject;
          //  Player.transform.parent = GameObject.Find("Player").transform;
        }
    }

    private void Update()
    {
        if (_CanChange)
        {

            Player = Instantiate(ActualWeapon) as GameObject;
            Player.transform.parent = GameObject.Find("Player").transform;
            _CanChange = false;
        }
    }
}
