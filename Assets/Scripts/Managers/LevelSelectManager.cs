using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
    public void LoadLevel(int index)
    {
        GameManager.Instance.isGameOver = false;
        MusicController.Instance.ChangeMusic(index);
        SceneManager.LoadScene(index);
    }
}
