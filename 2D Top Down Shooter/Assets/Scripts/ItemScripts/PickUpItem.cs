using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public bool pickedUp = false;
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        pickedUp = true;
        player.GetComponent<playerController>().itemID = gameObject.GetComponent<ItemID>().itemID;
        collision.GetComponent<playerController>().usingItem = true;
        int itemId = this.gameObject.GetComponent<ItemID>().itemID;
    }

    void Update()
    {
        if (pickedUp)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, player.transform.position.z - 1);
            transform.rotation = player.transform.rotation;
        }
    }
}
