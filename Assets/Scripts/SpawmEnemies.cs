using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

using Random = UnityEngine.Random;


public class SpawmEnemies : MonoBehaviour
{
    int countFrame = 0;
    public GameObject enemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int seed = Random.Range(0, 2);
        //int seed = 0;
        if (seed == 0 && countFrame == 120)
        {
            Instantiate(enemies, new Vector3(Random.Range(-50.0f,50.0f),130.0f,0), Quaternion.identity);
            countFrame = 0;
        }
        else if (seed == 1 && countFrame == 120)
        {
            Instantiate(enemies, new Vector3(100.0f, Random.Range(0.0f, 130.0f), 0), Quaternion.identity);
            countFrame = 0;
        }
        countFrame++;
    }
}
