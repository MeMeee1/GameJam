using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public GameEvent OnPauseGame;
    public GameEvent OnResumeGame;
    [SerializeField]GameEvent OnTutorialStart;
    public GameEvent OnEndTutorial;
    public bool StartGame;
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        PlayerPrefs.DeleteAll();

        if (PlayerPrefs.GetInt("FirstTime") == 0)
        {
            StartGame = false;
            PlayerPrefs.SetInt("FirstTime", 1);
            OnTutorialStart.Raise();
        }
        else
            StartGame = true;
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
       
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
       
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void EndTutorial()
    {
        OnEndTutorial.Raise();
        StartGame = true;
    }
}
