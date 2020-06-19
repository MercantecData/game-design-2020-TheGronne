using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopItemScript : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnpoints.Length; i++)
        {
            int randomItem = Random.Range(0, items.Length);
            switch (randomItem)
            {
                case 1:
                    //GameObject Item = Instantiate(items[randomItem], spawnpoints[i].position, spawnpoints[i].rotation);
                    Debug.Log(randomItem);
                    break;

                case 2:
                    Debug.Log(randomItem);
                    break;

                case 3:
                    Debug.Log(randomItem);
                    break;

                case 4:
                    Debug.Log(randomItem);
                    break;
                default:
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
