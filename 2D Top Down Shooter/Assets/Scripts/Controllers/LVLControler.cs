using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LVLControler : MonoBehaviour
{
    public GameObject player;
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject shop;
    public List<GameObject> SpawnedEnemies = new List<GameObject>();
    public int lvlCounter = 1;
    public GameObject currentlvl;
    public GameObject currentlvltext;
    public int numberOfEnemies;
    public GameObject enemiesleft;
    public GameObject victorymenu;
    public GameObject currentShop;
    public GameObject ammoLeftText;
    public GameObject ammoLeftUI;
    public GameObject amountOfCoins;
    public int firstTimeCounter; //Bliver brugt for at stoppe nogle ting i update sådan at de ikke kører mens man er i gang med noget andet
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
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
        amountOfCoins.GetComponent<Text>().text = player.GetComponent<playerController>().coins.ToString();
        if (player.GetComponent<playerController>().weapons.Count == 0)
        {
            ammoLeftUI.SetActive(false);
            player.GetComponent<playerController>().usingItem = false;
        }
        if (SpawnedEnemies.Count == 0 && firstTimeCounter == 0)
        {
            lvlCounter++;
            victoryMenu();
            firstTimeCounter = 1;
        }
        numberOfEnemies = SpawnedEnemies.Count;
        enemiesleft.GetComponent<Text>().text = ("Left: " + numberOfEnemies);
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
        currentlvltext.GetComponent<Text>().text = ("Current lvl: " + lvlCounter);
        firstTimeCounter = 0;
    }

    public void victoryMenu()
    {
        Time.timeScale = 0;
        victorymenu.SetActive(true);
    }

    public void goToShop()
    {
        Debug.Log(1);
        Time.timeScale = 1;
        Debug.Log(2);
        victorymenu.SetActive(false);
        Debug.Log(3);
        currentShop = Instantiate(shop);
        Debug.Log(4);
        GameObject.Find("Player").transform.position = new Vector2(-1.5f, -0.8f);
        Debug.Log(5);
        currentlvl.SetActive(false);
    }

    public void NextLevel()
    {
        victorymenu.SetActive(false);
        Time.timeScale = 1;
        newlvl();
    }
    private void FixedUpdate()
    {
        ammoLeftText.GetComponent<Text>().text = player.GetComponent<playerController>().weapons[player.GetComponent<swapItems>().currentWeapon - 1].GetComponent<WeaponStats>().ammo.ToString();
    }
}
