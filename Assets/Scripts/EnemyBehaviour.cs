//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class EnemyBehaviour : MonoBehaviour
{
    //public GameObject target;
    //Vector3 target = new Vector3(0.92f,1.26f,0.0f);
    public GameObject target;
    public AudioSource audio;
    public AudioClip clip;

    public float speed = 500.0f;
    public float rotationSpeed = 40.0f;
    Vector3 movement;

    
    public GameObject gameController;
    public GameObject sceneController;

    // Start is called before the first frame update
    void Start()
    {
        clip = Resources.Load<AudioClip>("SFX/Explosion");
        gameController = GameObject.Find("GameplayGameController");
        target = GameObject.Find("PlayerBase");
        movement = new Vector3();
        speed = Random.Range(500.0f,2500.0f);
        sceneController = GameObject.Find("SceneController");
    }

    void PlaySound(AudioClip aClip)
    {
        sceneController.GetComponent<MusicController>().PlayAudio(aClip);
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
            int temp = gameController.GetComponent<PlayGameController>().health;
            temp--;
            gameController.GetComponent<PlayGameController>().health = temp;
            PlaySound(clip);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Bullet" && transform.position.y < 100.0f)
        {
            PlaySound(clip);
            Destroy(this.gameObject);
        }
    }
}
