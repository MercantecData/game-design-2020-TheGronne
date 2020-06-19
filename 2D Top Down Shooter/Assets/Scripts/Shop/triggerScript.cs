using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    public bool isTriggered = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTriggered = true;
    }
}
