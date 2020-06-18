using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int hp;
    GameObject lvl;
    public GameObject[] itemDrops = new GameObject[1];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            if (gameObject.tag == "Enemy")
            {
                GameObject lvl = GameObject.Find("Controller");
                lvl.GetComponent<LVLControler>().SpawnedEnemies.Remove(gameObject);
                int randomSpawnPoints = Random.Range(1, 11);
                switch (randomSpawnPoints)
                {
                    case 1:
                        Instantiate(itemDrops[randomSpawnPoints - 1], gameObject.transform.position, gameObject.transform.rotation);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case 10:

                        break;
                    default:
                        break;
                }
            }
            Destroy(gameObject);
        }
    }
}
