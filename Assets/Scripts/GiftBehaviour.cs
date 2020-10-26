//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020


using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class GiftBehaviour : MonoBehaviour
{
    public float speed = 200.0f;
    public GameObject gameController;
    public GameObject sceneController;
    public AudioSource audio;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameplayGameController");
        sceneController = GameObject.Find("SceneController");
        clip = Resources.Load<AudioClip>("SFX/Power");
    }

    void PlaySound(AudioClip aClip)
    {
        sceneController.GetComponent<MusicController>().PlayAudio(aClip);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.up * speed * Time.deltaTime;
        if (transform.position.y < -20.0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet" && transform.position.y < 100.0f)
        {
            PlaySound(clip);
            int tempHealth = gameController.GetComponent<PlayGameController>().health;
            tempHealth += 2;
            gameController.GetComponent<PlayGameController>().health = tempHealth;
            int temp = gameController.GetComponent<PlayGameController>().score;
            temp += 5;
            gameController.GetComponent<PlayGameController>().score = temp;
            Destroy(this.gameObject);
        }
    }
}
