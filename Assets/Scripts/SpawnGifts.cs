//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGifts : MonoBehaviour
{
    private int countFrame = 0;
    public GameObject gift;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countFrame++;
        if (countFrame == 700)
        {
            Instantiate(gift, new Vector3(Random.Range(-30.0f, 45.0f), 110.0f, 1.0f), Quaternion.identity);
            countFrame = 0;
        }
    }
}
