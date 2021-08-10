using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] private float timer = default;

    void Start()
    {
        Invoke("Destroy", timer);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
