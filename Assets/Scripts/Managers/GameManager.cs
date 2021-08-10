using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
            Destroy(gameObject);
    }
    #endregion


    [HideInInspector] public int _score;
    [HideInInspector] public int _lives;
    [HideInInspector] public HUDManager hudManager;

    [SerializeField] private int maxLives = default;

    public static int LevelProgress;

    public int itemsRemaining;

    public bool isGameOver = false;
    public bool onPuzzle = false;
    public bool isTimePaused = false;
    public bool isGamePaused = false;

    public GameObject[] itemsRemainingGO;

    private void Start()
    {
        LevelProgress = 1;
    }

    public void ModifyLives(int value)
    {
        _lives -= value;
        hudManager.UpdateLives();
    }

    public void SetLivesStart()
    {
        _lives = maxLives;
    }

    public void GetItemsRemaining()
    {
        itemsRemainingGO = GameObject.FindGameObjectsWithTag("Items");
        itemsRemaining = itemsRemainingGO.Length;
    }

    public void ModifyItems(int value)
    {
        itemsRemaining += value;
    }

    public void RestartGame()
    {
        isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        MusicController.Instance.ChangeMusic(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        MusicController.Instance.ChangeMusic(0);
        SceneManager.LoadScene(0);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void PauseTime()
    {
        isTimePaused = true;
        Time.timeScale = 0;
    }

    public void ResumeTime()
    {
        Time.timeScale = 1;
        isTimePaused = false;
    }

    public void GameOver()
    {
        isGameOver = true;
    }

    public void PauseGame()
    {
        PauseTime();
        isGamePaused = true;
    }

    public void ResumeGame()
    {
        isGamePaused = false;
        ResumeTime();
    }

    public void StartGame()
    {
        isGameOver = false;
        LevelProgress = 1;
        MusicController.Instance.ChangeMusic(SceneManager.GetActiveScene().buildIndex + 2);
        SceneManager.LoadScene(2);
    }
}
