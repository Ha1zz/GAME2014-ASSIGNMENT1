//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020


using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class OverGameController : MonoBehaviour
{
    private Text scoreText;
    private Text highestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        highestScoreText = GameObject.Find("HighestScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int temp;
        if (PlayerPrefs.HasKey("HighestScore"))
        {
            if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighestScore"))
            {
                temp = PlayerPrefs.GetInt("Score");
                PlayerPrefs.SetInt("HighestScore", temp);
            }
        }
        else
        {
            temp = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("HighestScore", temp);
        }
        temp = 0;
        highestScoreText.text = PlayerPrefs.GetInt("HighestScore").ToString();
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
