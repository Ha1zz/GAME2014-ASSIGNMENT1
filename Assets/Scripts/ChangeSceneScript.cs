//Name: Tran Thien Phu
//ID: 101160213
//Date Last Modifield: 20/10/2020

using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {

    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    //[SerializeField] private string sceneName;

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
