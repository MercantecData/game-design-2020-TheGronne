using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponClass : MonoBehaviour
{
    public GameObject player;
    public GameObject hand;
    public bool itemUsing = false;
    public int plzwork = 0;
    protected void Start()
    {
        player = GameObject.Find("Player");
        hand = GameObject.Find("hand");
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("PICKED UP");
        for (int i = 0; i < player.GetComponent<playerController>().weapons.Count; i++)
        {
            player.GetComponent<playerController>().weapons[i].GetComponent<WeaponClass>().itemUsing = false;
        }
        if (plzwork == 0) //Triggeren triggede mere end 1 gang, så lavede dette
        {
            player.GetComponent<playerController>().weapons.Add(gameObject);
            player.GetComponent<swapItems>().currentWeapon = player.GetComponent<playerController>().weapons.Count;
            plzwork++;
        }
        player.GetComponent<playerController>().itemID = gameObject.GetComponent<WeaponStats>().itemID;
        collision.GetComponent<playerController>().usingItem = true;
        itemUsing = true;
        GameObject.Find("Controller").GetComponent<LVLControler>().ammoLeftUI.SetActive(true);
    }

    protected void Update()
    {
        if (itemUsing)
        {
            gameObject.transform.position = new Vector3(hand.transform.position.x, hand.transform.position.y, hand.transform.position.z - 1);
            transform.rotation = player.transform.rotation;
        }
    }
}
