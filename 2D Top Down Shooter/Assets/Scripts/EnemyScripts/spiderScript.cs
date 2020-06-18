﻿using System.Collections;
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
    private void Update()
    {
        Vector3 moveDirection = gameObject.transform.position - player.transform.position;
        if (moveDirection != Vector3.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.Rotate(0f, 0f, -90f);
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