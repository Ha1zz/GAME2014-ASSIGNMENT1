using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class GiftBehaviour : MonoBehaviour
{
    public float speed = 100.0f;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameplayGameController");
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

            int temp = gameController.GetComponent<PlayGameController>().score;
            temp += 5;
            gameController.GetComponent<PlayGameController>().score = temp;
            Destroy(this.gameObject);
        }
    }
}
