using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject bigBeamPrefab;

    public float nextFire;
    public float fireRate;

    public float bigBeamNextFire;
    public float bigBeamFireRate;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)  
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }

        if (Input.GetKey(KeyCode.B) && Time.time > bigBeamNextFire)
        {
            bigBeamNextFire = Time.time + bigBeamFireRate;
            ShootBigBeam();
        }
    }

    void Shoot ()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);

    }

    void ShootBigBeam()
    {
        Instantiate(bigBeamPrefab, firePoint.position, transform.rotation);
    }
}
