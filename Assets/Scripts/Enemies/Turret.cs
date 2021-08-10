using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private float timerMax = 0;
    private float timerCount;


    [SerializeField] private GameObject projectile = default;
    [SerializeField] private GameObject turret = default;
    [SerializeField] private Transform bullets = default;

    private void Update()
    {
        if (timerCount <= timerMax)
        {
            timerCount += Time.deltaTime;
        }

        else
        {
            GameObject temp = Instantiate(projectile, turret.transform.position, transform.rotation, bullets);
            transform.Rotate(0, 0, 90);
            timerCount = 0;
        }

    }
}
