using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    public float speed = 0.0025f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed / 10.0f; 

        if (transform.position.x > 70 || transform.position.y > 120)
        {
            Destroy(this.gameObject);
        }
    }
}
