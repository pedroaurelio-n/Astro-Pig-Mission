using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    [SerializeField] private GameObject nextlevelCanvas = default;
    [SerializeField] private GameObject gameoverCanvas = default;
    [SerializeField] private GameObject pauseCanvas = default;
    [SerializeField] private UILevelManager levelManager = default;

    [SerializeField] private Text scoreTxt = default;
    [SerializeField] private Text itemsTxt = default;

    [SerializeField] GameObject[] livesSpriteUI = default;

    private GameObject infoCanvas;


    private void Start()
    {
        GameManager.Instance.hudManager = this;

        infoCanvas = GameObject.FindGameObjectWithTag("InfoCanvas");

        if (infoCanvas == null)
            GameManager.Instance.ResumeTime();

        else
            GameManager.Instance.PauseTime();


        GameManager.Instance.GetItemsRemaining();
        GameManager.Instance.SetLivesStart();
        UpdateLives();

        gameoverCanvas.SetActive(false);
        nextlevelCanvas.SetActive(false);
        pauseCanvas.SetActive(false);

        GameManager.Instance.isGamePaused = false;
    }

    private void Update()
    {
        scoreTxt.text = "Score: " + GameManager.Instance._score;
        //livesTxt.text = "Lives: " + GameManager.Instance._lives;
        itemsTxt.text = "x" + GameManager.Instance.itemsRemaining;

        if (GameManager.Instance.itemsRemaining <= 0 && nextlevelCanvas.activeSelf == false)
        {
            levelManager.UpdateLevelProgress();
            nextlevelCanvas.SetActive(true);
            GameManager.Instance.PauseTime();
        }

        if (GameManager.Instance.isGamePaused && pauseCanvas.activeSelf == false)
        {
            pauseCanvas.SetActive(true);
        }

        else if (!GameManager.Instance.isGamePaused && pauseCanvas.activeSelf == true)
        {
            pauseCanvas.SetActive(false);
        }
    }

    public void UpdateLives()
    {
        switch (GameManager.Instance._lives)
        {
            case 3:
                livesSpriteUI[2].SetActive(true);
                livesSpriteUI[1].SetActive(true);
                livesSpriteUI[0].SetActive(true);
                break;

            case 2:
                livesSpriteUI[2].SetActive(false);
                break;

            case 1:
                livesSpriteUI[2].SetActive(false);
                livesSpriteUI[1].SetActive(false);
                break;

            default:
                livesSpriteUI[2].SetActive(false);
                livesSpriteUI[1].SetActive(false);
                livesSpriteUI[0].SetActive(false);

                if (gameoverCanvas.activeSelf == false)
                {
                    gameoverCanvas.SetActive(true);
                    GameManager.Instance.GameOver();
                }
                break;
        }
    }
}
