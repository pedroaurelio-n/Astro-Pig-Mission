using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetButtonEventTrigger : MonoBehaviour
{
    EventSystem eventSystem;
    Button button;

    private void Start()
    {
        /*eventSystem = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>();
        button = GetComponent<Button>();
        eventSystem.SetSelectedGameObject(button.gameObject);*/
    }

    private void OnEnable()
    {
        eventSystem = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>();
        button = GetComponent<Button>();
        eventSystem.SetSelectedGameObject(button.gameObject);
    }

    private void OnDisable()
    {
        /*eventSystem = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>();
        eventSystem.SetSelectedGameObject(null);*/
    }
}
