//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    public float speed = 0.0025f;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameplayGameController");
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

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //int tempHealth = gameController.GetComponent<PlayGameController>().health;
            //tempHealth++;
            //gameController.GetComponent<PlayGameController>().health = tempHealth;
            int tempScore = gameController.GetComponent<PlayGameController>().score;
            tempScore++;
            gameController.GetComponent<PlayGameController>().score = tempScore;
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Gift")
        {
            Destroy(this.gameObject);
        }
    }
}
