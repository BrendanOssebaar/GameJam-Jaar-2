using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerShooting : MonoBehaviour
{
    public Transform firepoint;

    void Shoot()
    {
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
}
