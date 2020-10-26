//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020





using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public AudioClip menuClip;
    public AudioClip playClip;
    public AudioClip overClip;
    public AudioClip introClip;
    public AudioSource audioSource;
    private string sceneName;
    bool canPlay;

    public void PlayAudio(AudioClip clip)
    {

        if (canPlay)
            canPlay = false;
        GetComponent<AudioSource>().PlayOneShot(clip);

        StartCoroutine(Reset());
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(.2f);
        canPlay = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        menuClip = Resources.Load<AudioClip>("Sounds/Menu");
        playClip = Resources.Load<AudioClip>("Sounds/PlayScene");
        overClip = Resources.Load<AudioClip>("Sounds/GameOver");
        introClip = Resources.Load<AudioClip>("Sounds/Introduction");
        sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "GameOverScreen")
        {
            audioSource.PlayOneShot(overClip);
        }
        if (sceneName == "GameplayScreen1")
        {
            audioSource.PlayOneShot(playClip);
        }
        if (sceneName == "InstructionsScreen")
        {
            audioSource.PlayOneShot(introClip);
        }
        if (sceneName == "MenuScreen")
        {
            audioSource.PlayOneShot(menuClip);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
