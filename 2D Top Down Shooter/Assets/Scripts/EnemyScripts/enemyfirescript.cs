using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfirescript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthController>().hp -= gameObject.GetComponent<DamageController>().damage;
        }
        Destroy(gameObject);
    }
}
