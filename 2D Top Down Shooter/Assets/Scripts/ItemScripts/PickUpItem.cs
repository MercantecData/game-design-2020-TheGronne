using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public bool pickedUp = false;
    public GameObject player;
    public GameObject hand;
    public bool itemUsing = false;
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
        if (player.GetComponent<playerController>().weapons.Count == 1)
        {

        } else 
        {
            GameObject currentUsedItem = player.GetComponent<playerController>().weapons.Find(x => x.GetComponent<PickUpItem>().itemUsing = true);
            currentUsedItem.SetActive(false);
        }
        itemUsing = true;
    }

    void Update()
    {
        if (pickedUp)
        {
            gameObject.transform.position = new Vector3(hand.transform.position.x, hand.transform.position.y, hand.transform.position.z - 1);
            transform.rotation = player.transform.rotation;
            if (itemUsing == true)
            {
                gameObject.SetActive(true);
            } else if (itemUsing == false)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
