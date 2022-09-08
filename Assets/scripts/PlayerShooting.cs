using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerShooting : MonoBehaviour
{
    public Transform firepoint;
    public Transform firepoint1;
    public Transform firepoint2;
    public GameObject bulletPrefab;
    void Shootpistol()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
    void ShootShotgun()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Instantiate(bulletPrefab, firepoint1.position, firepoint1.rotation);
        Instantiate(bulletPrefab, firepoint2.position, firepoint2.rotation);
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") /*&& hasPistol == true*/)
        {
            Shootpistol();
        }
        if (Input.GetButtonDown("Fire2")/* && hasShotgun == true*/)
        {
            ShootShotgun();
        }
    }
}
