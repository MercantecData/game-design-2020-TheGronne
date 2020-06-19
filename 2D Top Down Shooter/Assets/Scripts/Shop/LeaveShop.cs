using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveShop : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(GameObject.Find("Controller").GetComponent<LVLControler>().currentShop);
            GameObject.Find("Controller").GetComponent<LVLControler>().newlvl();
            GameObject.Find("Controller").GetComponent<LVLControler>().firstTimeCounter = 0;
        }
    }
}
