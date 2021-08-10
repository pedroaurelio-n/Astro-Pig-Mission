using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [SerializeField] private float shootTimer = default;
    private float shootCounter;


    [SerializeField] private PlayerController1 playerController = default;
    [SerializeField] private Rigidbody2D rb = default;


    [SerializeField] private GameObject projectile = default;
    [SerializeField] private Transform bullets = default;

    [SerializeField] private Transform burstPos = default;
    [SerializeField] private GameObject shotBurst = default;


    private void Start()
    {
        shootCounter = shootTimer;
    }

    private void Update()
    {
        if (shootCounter <= shootTimer)
        {
            shootCounter += Time.deltaTime;
        }
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (shootCounter >= shootTimer && Mathf.Abs(rb.velocity.x) < 0.3f && Mathf.Abs(rb.velocity.y) < 0.3f && !GameManager.Instance.isTimePaused)
        {
            playerController.isShooting = true;
            GameObject temp = Instantiate(projectile, transform.position, transform.rotation, bullets);
            AudioController.Instance.PlayAudio(3);
            GameObject temp2 = Instantiate(shotBurst, burstPos.position, burstPos.rotation);
            shootCounter = 0;
        }
    }
}
