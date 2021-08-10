using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOButton_Reference : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickRestart);
    }

    void OnClickRestart()
    {
        GameManager.Instance.RestartGame();
    }
}
