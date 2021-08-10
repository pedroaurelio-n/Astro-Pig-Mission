using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelManager : MonoBehaviour
{
    [HideInInspector] public int levelReference;

    public void RestartGame()
    {
        GameManager.Instance.RestartGame();
    }

    public void NextLevel()
    {
        GameManager.Instance.NextLevel();
    }

    public void MainMenu()
    {
        GameManager.Instance.MainMenu();
    }

    public void PauseGame()
    {
        GameManager.Instance.PauseGame();
    }

    public void ResumeGame()
    {
        GameManager.Instance.ResumeGame();
    }

    public void UpdateLevelProgress()
    {
        if (GameManager.LevelProgress == levelReference)
            GameManager.LevelProgress++;
    }
}
