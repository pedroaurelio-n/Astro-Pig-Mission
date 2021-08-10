using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInfo : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(true);
        GameManager.Instance.PauseTime();
    }


    public void CloseInfoCanvas()
    {
        gameObject.SetActive(false);
        GameManager.Instance.ResumeTime();
    }

    private void OnEnable()
    {
        GameManager.Instance.PauseTime();
    }
}
