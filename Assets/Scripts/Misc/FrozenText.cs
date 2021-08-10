using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrozenText : MonoBehaviour
{
    private int timerStart = 10;

    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().sortingLayerName = "HUD";
        Destroy(gameObject, 11f);
        StartCoroutine(TimerCount());
    }

    private IEnumerator TimerCount()
    {
        while (true)
        {
            gameObject.GetComponent<TextMesh>().text = timerStart.ToString();
            timerStart -= 1;
            yield return new WaitForSeconds(1f);
        }
    }
}
