using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Player") || collision.gameObject.tag.Contains("Item"))
        {
            
        } else if (collision.gameObject.tag.Contains("Enemy"))
        {
            collision.gameObject.GetComponent<HealthController>().hp -= this.gameObject.GetComponent<DamageController>().damage;
            Destroy(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
}
