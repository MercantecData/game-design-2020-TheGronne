using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public GameObject player;
    public GameObject hand;
    public bool itemUsing = false;
    public int plzwork = 0;
    void Start()
    {
        player = GameObject.Find("Player");
        hand = GameObject.Find("hand");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("PICKED UP");
        for (int i = 0; i < player.GetComponent<playerController>().weapons.Count; i++)
        {
            player.GetComponent<playerController>().weapons[i].GetComponent<PickUpItem>().itemUsing = false;
        }
        if (plzwork == 0) //Triggeren triggede mere end 1 gang, så lavede dette
        {
            player.GetComponent<playerController>().weapons.Add(gameObject);
            player.GetComponent<swapItems>().currentWeapon = player.GetComponent<playerController>().weapons.Count;
            plzwork++;
        }
        player.GetComponent<playerController>().itemID = gameObject.GetComponent<ItemID>().itemID;
        collision.GetComponent<playerController>().usingItem = true;
        itemUsing = true;
    }

    void Update()
    {
        if (itemUsing)
        {
            gameObject.transform.position = new Vector3(hand.transform.position.x, hand.transform.position.y, hand.transform.position.z - 1);
            transform.rotation = player.transform.rotation;
            /*if (itemUsing == true)
            {
                gameObject.SetActive(true);
            } else if (itemUsing == false)
            {
                gameObject.SetActive(false);
            }*/
        }
    }
}
