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
    public GameObject shotgunPrefab;
    public float fireRatePistol;
    public float fireRateShotgun;
    public float nextFire1;
    public float nextFire2;
    void Shootpistol()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        nextFire1 = Time.time + fireRatePistol;
    }
    void ShootShotgun()
    {
        Instantiate(shotgunPrefab, firepoint.position, firepoint.rotation);
        Instantiate(shotgunPrefab, firepoint1.position, firepoint1.rotation);
        Instantiate(shotgunPrefab, firepoint2.position, firepoint2.rotation);
        nextFire2 = Time.time + fireRateShotgun;
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire1 && selectedweapon == 0)
        {
            Shootpistol();
        }
        if (Input.GetButton("Fire2") && Time.time > nextFire2 && selectedweapon != 0)
        {
            ShootShotgun();
        }
    }
}
