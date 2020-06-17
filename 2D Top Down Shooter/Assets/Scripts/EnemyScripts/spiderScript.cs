using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderScript : EnemyScript
{
    void Start()
    {
        speed = 2;
        int randomNumber = Random.Range(1, 5);
        int randomN = randomNumber;
        switch (randomN)
        {
            case 1:
                element = "fire";
                break;
            case 2:
                element = "water";
                break;
            case 3:
                element = "electric";
                break;
            case 4:
                element = "void";
                break;
            default:
                element = "void";
                break;
        }
    }
    void FixedUpdate()
    {
        player = GameObject.Find("Player");
        Vector3 target = player.transform.position;
        target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}