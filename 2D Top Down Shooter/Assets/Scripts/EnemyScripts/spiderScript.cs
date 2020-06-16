using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderScript : EnemyScript
{
    void Start()
    {
        gameObject.GetComponent<HealthController>().hp = 100;
        speed = 2;
    }
    void FixedUpdate()
    {
        player = GameObject.Find("Player");
        Vector3 target = player.transform.position;
        target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}