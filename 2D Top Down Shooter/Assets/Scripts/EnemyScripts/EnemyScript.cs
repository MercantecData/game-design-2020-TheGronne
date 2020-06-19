using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    public string element;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Player"))
        {
            //collision.gameObject.GetComponent<HealthController>().hp -= this.gameObject.GetComponent<DamageController>().damage;
        }
    }
}
