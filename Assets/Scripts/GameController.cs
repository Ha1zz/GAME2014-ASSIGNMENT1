using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;
using System.Globalization;
using System.ComponentModel.Design;

public class GameController : MonoBehaviour
{
    private Text healthText;
    private Text scoreText;
    private int health = 5;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GameObject.Find("Health").GetComponent<Text>();
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();
        scoreText.text = score.ToString();
        if (health <= 0)
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene("GameOverScreen");
        }
    }
}
