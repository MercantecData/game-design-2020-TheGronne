using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject waterDrop;

    public float bulletForce = 15f;
    public float cooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown >= 0)
        {
            cooldown -= Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            shoot();
        }
    }

    void shoot()
    {
        if (gameObject.GetComponent<playerController>().usingItem == false)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            cooldown = 0.5f;
        } 
        else if (gameObject.GetComponent<playerController>().itemID == 1)
        {
            bulletForce = 10f;
            GameObject bullet = Instantiate(waterDrop, firePoint.position, firePoint.rotation);
            bullet.GetComponent<DamageController>().element = "water";
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            cooldown = 1;
        }
    }
}
