using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LVLControler : MonoBehaviour
{
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;
    public List<GameObject> SpawnedEnemies = new List<GameObject>();
    public int lvlCounter;
    public GameObject currentlvl;
    public GameObject currentlvltext;
    // Start is called before the first frame update
    void Start()
    {
        int randomLVL = Random.Range(1,4);
        switch (randomLVL)
        {
            case 1:
                currentlvl = Instantiate(lvl1);
                break;
            case 2:
                currentlvl = Instantiate(lvl2);
                break;
            case 3:
                currentlvl = Instantiate(lvl3);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnedEnemies.Count == 0)
        {
            lvlCounter++;
            newlvl();
        }
    }

    public void newlvl()
    {
        currentlvl.SetActive(false);
        int randomLVL = Random.Range(1, 4);
        switch (randomLVL)
        {
            case 1:
                currentlvl = Instantiate(lvl1);
                break;
            case 2:
                currentlvl = Instantiate(lvl2);
                break;
            case 3:
                currentlvl = Instantiate(lvl3);
                break;
            default:
                break;
        }
        GameObject.Find("Player").transform.position = new Vector2(-1.5f, -0.8f);
        for (int i = 0; i < SpawnedEnemies.Count; i++)
        {
            SpawnedEnemies[i].GetComponent<DamageController>().damage += 3;
            SpawnedEnemies[i].GetComponent<spiderScript>().speed += 0.25f;
            SpawnedEnemies[i].GetComponent<waspScript>().speed += 0.5f;
        }
        currentlvltext.GetComponent<Text>().text = ("Current lvl: " + currentlvl);
    }
}
