using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public bool pickedUp = false;
    public GameObject player;
    public GameObject hand;
    void Start()
    {
        player = GameObject.Find("Player");
        hand = GameObject.Find("hand");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        pickedUp = true;
        player.GetComponent<playerController>().weapons.Add(gameObject);
        player.GetComponent<playerController>().itemID = gameObject.GetComponent<ItemID>().itemID;
        collision.GetComponent<playerController>().usingItem = true;
        int itemId = this.gameObject.GetComponent<ItemID>().itemID;
    }

    void Update()
    {
        if (pickedUp)
        {
            gameObject.transform.position = new Vector3(hand.transform.position.x, hand.transform.position.y, hand.transform.position.z - 1);
            transform.rotation = player.transform.rotation;
        }
    }
}
