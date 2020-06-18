using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<HealthController>().hp < 100)
        {
            if (collision.GetComponent<HealthController>().hp <= 90)
            {
                collision.GetComponent<HealthController>().hp += 10;
            } else
            {
                collision.GetComponent<HealthController>().hp += 100 - collision.GetComponent<HealthController>().hp;
            }
        }
        Destroy(gameObject);
    }
}
