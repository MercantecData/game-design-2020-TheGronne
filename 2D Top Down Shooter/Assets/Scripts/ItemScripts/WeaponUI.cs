using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUI : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer weaponUI;

    public Sprite Bow;
    public Sprite WaterStaff;
    public Sprite FireSword;
    public Sprite ElectricStaff;
    public Sprite VoidStaff;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        switch (player.GetComponent<playerController>().itemID)
        {
            case 0:
                weaponUI.sprite = Bow;
                weaponUI.color = new Color(1f,1f,1f,1f);
                break;
            case 1:
                weaponUI.sprite = WaterStaff;
                break;
            case 2:
                weaponUI.sprite = FireSword;
                break;
            case 3:
                weaponUI.sprite = ElectricStaff;
                break;
            case 4:
                weaponUI.sprite = VoidStaff;
                break;
            default:

                break;
        }
    }
}
