using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator = default;
    [SerializeField] private SpriteRenderer sprite = default;

    private Rigidbody2D rb;
    private PlayerController1 playerController;

    private string currentState;

    private bool isCRHitPlaying;
    private bool isCRShootPlaying;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerController = GetComponent<PlayerController1>();
        playerController.animationIntDirection = 2;
    }

    private void Update()
    {
        if (playerController.movementInput != Vector2.zero)
        {
            CheckDirection();
        }

        if (!isCRShootPlaying)
        {
            switch (playerController.animationIntDirection)
            {
                case 1:
                    sprite.flipX = false;
                    if (rb.velocity.y > 0.6)
                        ChangeAnimationState("player_walk_up");

                    else
                        ChangeAnimationState("player_idle_up");

                    break;


                case 2:
                    sprite.flipX = false;
                    if (Mathf.Abs(rb.velocity.x) > 0.6)
                        ChangeAnimationState("player_walk_side");

                    else
                        ChangeAnimationState("player_idle_right");

                    break;


                case 3:
                    sprite.flipX = false;
                    if (rb.velocity.y < -0.6)
                        ChangeAnimationState("player_walk_down");

                    else
                        ChangeAnimationState("player_idle_down");

                    break;


                case 4:
                    if (Mathf.Abs(rb.velocity.x) > 0.6)
                    {
                        sprite.flipX = true;
                        ChangeAnimationState("player_walk_side");
                    }

                    else
                    {
                        sprite.flipX = false;
                        ChangeAnimationState("player_idle_left");
                    }

                    break;
            }
        }


        if (playerController.wasHit && !isCRHitPlaying)
        {
            StartCoroutine(DamageAnimation());
        }

        if (playerController.isShooting && !isCRShootPlaying)
        {
            StartCoroutine(ShootAnimation());
        }
    }


    private void ChangeAnimationState(string newState)
    {
        if (currentState == newState)
            return;

        animator.Play(newState);

        currentState = newState;
    }


    private void CheckDirection()
    {
        if (!GameManager.Instance.isTimePaused)
        {
            if (playerController.movementInput.x > 0.1)
            {
                playerController.animationIntDirection = 2;
            }

            else if (playerController.movementInput.x < -0.1)
            {
                playerController.animationIntDirection = 4;
            }

            else if (playerController.movementInput.y > 0.1)
            {
                playerController.animationIntDirection = 1;
            }

            else if (playerController.movementInput.y < -0.1)
            {
                playerController.animationIntDirection = 3;
            }
        }
    }


    private IEnumerator DamageAnimation()
    {
        isCRHitPlaying = true;

        for (int i = 0; i < 3; i++)
        {

            sprite.color = Color.red;
            yield return new WaitForSeconds(0.3f);

            sprite.color = Color.white;
            yield return new WaitForSeconds(0.3f);
        }

        isCRHitPlaying = false;
        playerController.wasHit = false;
    }


    private IEnumerator ShootAnimation()
    {
        isCRShootPlaying = true;

        switch (playerController.animationIntDirection)
        {
            case 1:
                ChangeAnimationState("player_shoot_up");
                yield return new WaitForSeconds(0.2f);
                break;

            case 2:
                ChangeAnimationState("player_shoot_right");
                yield return new WaitForSeconds(0.2f);
                break;

            case 3:
                ChangeAnimationState("player_shoot_down");
                yield return new WaitForSeconds(0.2f);
                break;

            case 4:
                ChangeAnimationState("player_shoot_left");
                yield return new WaitForSeconds(0.2f);
                break;
        }

        isCRShootPlaying = false;
        playerController.isShooting = false;
    }
}
