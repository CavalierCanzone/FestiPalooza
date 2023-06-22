using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float shootingSpeed = 2f;
    float timer = 0f;
    int randomNumber = 0;
    public int shootingChance = 9;


    void Start() 
    {
      
    }

    void Update()
    {
       
      timer += Time.deltaTime;

        if (timer >= shootingSpeed)
        {
            randomNumber = Random.Range(1, shootingChance);
               if (randomNumber == 1 || randomNumber == 2)
                   {
                    var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;

                    timer = 0f;
                   }
              else
              {
                   timer = 0f;
              }

        }
       
    }

    
}
