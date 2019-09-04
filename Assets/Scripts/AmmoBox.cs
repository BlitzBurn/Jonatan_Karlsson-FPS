﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{

    private int AmmoInBox = 10;
    private void Start()
    {
        
       
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player" && ShootWeapon.currentAmmo<ShootWeapon.maxAmmo)
        {
            AmmoBoxSounds ammoBoxSounds = gameObject.GetComponent<AmmoBoxSounds>();
          
            ShootWeapon.currentAmmo += AmmoInBox;
            Destroy(gameObject);
        }
    }

}
