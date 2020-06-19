using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopItemScript : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] items;
    public List<GameObject> spawnedItems = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnpoints.Length; i++)
        {
            int randomItem = Random.Range(0, items.Length);
            GameObject Item = Instantiate(items[randomItem], spawnpoints[i].position, spawnpoints[i].rotation);
            Item.AddComponent<triggerScript>();
            spawnedItems.Add(Item);
        }
    }

    private void Update()
    {
        for (int i = 0; i < spawnedItems.Count; i++)
        {
            if (spawnedItems[i].GetComponent<triggerScript>().isTriggered == true)
            {
                spawnedItems.Remove(spawnedItems[i]);
                for (int ii = 0; ii < spawnedItems.Count; ii++)
                {
                    Destroy(spawnedItems[ii]);
                }
            }
        }
    }
}
