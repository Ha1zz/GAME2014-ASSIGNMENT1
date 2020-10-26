//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class PlayerController : MonoBehaviour
{
    public float rotateSpeed = 60.0f;
    public GameObject bullet;
    private int countFrame = 0;
    public AudioSource audio;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        clip = Resources.Load<AudioClip>("SFX/Firing");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            float angle = Mathf.Atan2(touch.position.y - transform.position.y, touch.position.x - transform.position.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            //angle -= 180;
            //Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);


            angle -= 90;
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Instantiate(bullet, transform.position + transform.right * 32.0f + transform.up * 6.5f, targetRotation);
                audio.PlayOneShot(clip);
            }
        }
        countFrame++;
        if (countFrame == 120)
        {
            countFrame = 0;
        }
    }
}
