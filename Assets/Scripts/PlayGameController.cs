//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;
using System.Globalization;
using System.ComponentModel.Design;

public class PlayGameController : MonoBehaviour
{
    private Text healthText;
    private Text scoreText;
    public int health = 100;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GameObject.Find("Health").GetComponent<Text>();
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 100)
            health = 100;
        healthText.text = health.ToString();
        scoreText.text = score.ToString();
        if (health <= 0)
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene("GameOverScreen");
        }
    }
}
