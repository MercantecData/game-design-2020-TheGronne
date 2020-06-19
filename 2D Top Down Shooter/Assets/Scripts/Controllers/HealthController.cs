using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int hp;
    GameObject lvl;
    public GameObject[] itemDrops = new GameObject[6];
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
                        int item = Random.Range(0, 11);
                        switch (item)
                        {
                            case 0:
                                Instantiate(itemDrops[0], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 1:
                                Instantiate(itemDrops[1], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 2:
                                Instantiate(itemDrops[0], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 3:
                                Instantiate(itemDrops[1], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 4:
                                Instantiate(itemDrops[0], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 5:
                                Instantiate(itemDrops[1], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 6:
                                Instantiate(itemDrops[0], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 7:
                                Instantiate(itemDrops[1], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 8:
                                Instantiate(itemDrops[0], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 9:
                                Instantiate(itemDrops[1], gameObject.transform.position, gameObject.transform.rotation);
                                break;
                            case 10:
                                int weapon = Random.Range(0, itemDrops.Length - 2);
                                switch (weapon)
                                {
                                    case 0:
                                        Instantiate(itemDrops[2], gameObject.transform.position, gameObject.transform.rotation);
                                        break;
                                    case 1:
                                        Instantiate(itemDrops[3], gameObject.transform.position, gameObject.transform.rotation);
                                        break;
                                    case 2:
                                        Instantiate(itemDrops[4], gameObject.transform.position, gameObject.transform.rotation);
                                        break;
                                    case 3:
                                        Instantiate(itemDrops[5], gameObject.transform.position, gameObject.transform.rotation);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
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
