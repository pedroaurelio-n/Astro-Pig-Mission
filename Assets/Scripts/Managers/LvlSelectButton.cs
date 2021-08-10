using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlSelectButton : MonoBehaviour
{
    [SerializeField] private int threshold = default;

    //SpriteRenderer sprite;
    Button button;

    private void Start()
    {
        //sprite = GetComponent<SpriteRenderer>();
        button = GetComponent<Button>();
    }

    private void Update()
    {
        if (GameManager.LevelProgress >= threshold)
        {
            button.interactable = true;
            gameObject.SetActive(true);
        }

        else
        {
            button.interactable = false;
            gameObject.SetActive(false);
        }
    }
}
