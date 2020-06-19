using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waspScript : EnemyScript
{
    void Start()
    {
        player = GameObject.Find("Player");
        speed = 3;
        element = "electric";
    }

    private void Update()
    {
        if (player.transform.position.x > gameObject.transform.position.x)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        } else if (player.transform.position.x < gameObject.transform.position.x)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

    }

    void FixedUpdate()
    {
        Vector3 target = player.transform.position;
        target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
