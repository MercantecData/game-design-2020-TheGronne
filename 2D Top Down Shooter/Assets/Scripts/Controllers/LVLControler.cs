using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLControler : MonoBehaviour
{
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;

    // Start is called before the first frame update
    void Start()
    {
        int randomLVL = Random.Range(1,4);
        switch (randomLVL)
        {
            case 1:
                Instantiate(lvl1);
                break;
            case 2:
                Instantiate(lvl1);
                break;
            case 3:
                Instantiate(lvl1);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
