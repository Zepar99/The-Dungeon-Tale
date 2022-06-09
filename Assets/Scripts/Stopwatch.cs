using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class Stopwatch : MonoBehaviour
{
    public bool stopWatchActive = true;
    public float currentTime;
    public Text currentTimeText;
    public GameObject objectToDisable;
    public GameObject objectToEnable;
    public string scene;
    public string menu;


    void Update()
    {
        if (stopWatchActive == true)
        {
            currentTime = currentTime - Time.deltaTime;
            if (currentTime <= 0)
            {
                stopTime();
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = "TIME LEFT : " + time.Minutes.ToString("00") + ":" + time.Seconds.ToString("00");
    }
    public void stopTime()
    {
        objectToEnable.SetActive(true);
        GameState currentGameState = GmaeStateManager.Instance.currentGameState;
        GameState newGameState = currentGameState == GameState.Gameplay
           ? GameState.Gameloose
           : GameState.Gameplay;
        GmaeStateManager.Instance.SetState(newGameState);
        stopWatchActive = false;


    }
    public void Retry()
    {
        objectToDisable.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);

    }
    public void Menu()
    {
        SceneManager.LoadScene(menu);
        Time.timeScale = 1f;
    }


}
