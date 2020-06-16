using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderScript : MonoBehaviour
{
    public int hp;
    public float speed;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        Vector3 target = player.transform.position;
        target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
