using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerShooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
}
