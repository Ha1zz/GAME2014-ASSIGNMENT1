using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class EnemyBehaviour : MonoBehaviour
{
    //public GameObject target;
    //Vector3 target = new Vector3(0.92f,1.26f,0.0f);
    public GameObject target;

    public float speed = 500.0f;
    public float rotationSpeed = 40.0f;
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("PlayerBase");
        movement = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Atan2(transform.position.y - target.transform.position.y, transform.position.x - target.transform.position.x) * Mathf.Rad2Deg;
        angle += 90;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speed * Time.deltaTime);


        movement = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime / 10.0f);
        this.transform.position = movement;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
