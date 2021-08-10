using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NLButton_Reference : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickContinue);
    }

    void OnClickContinue()
    {
        GameManager.Instance.NextLevel();
    }
}
