using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Contains("Player"))
        {

        } else if (collision.gameObject.tag.Contains("Enemy"))
        {
            collision.gameObject.GetComponent<spiderScript>().hp -= 10;
            Destroy(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
}
