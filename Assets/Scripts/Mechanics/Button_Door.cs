using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Door : MonoBehaviour
{
    [SerializeField] private Door doorScript = default;

    private Animator animator;

    private bool isActivated = false;
    private string currentState;

    private int collisionNumber;

    private void Start()
    {
        collisionNumber = 0;
        isActivated = false;
        animator = GetComponent<Animator>();
        ChangeAnimationState("Button_Gameplay_Off");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("Player") || collision.CompareTag("FrozenEnemy") || collision.CompareTag("Enemy")))
        {
            collisionNumber++;
            if (collisionNumber > 0 && isActivated == false)
            {
                isActivated = true;
                ChangeAnimationState("Button_Gameplay_On");
                if (!doorScript.isActivatedBySwitch)
                    doorScript.ActivateDoor();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("FrozenEnemy") || collision.CompareTag("Enemy"))
        {
            collisionNumber--;
            if (collisionNumber == 0 && isActivated == true)
            {
                isActivated = false;
                ChangeAnimationState("Button_Gameplay_Off");
                if (!doorScript.isActivatedBySwitch)
                    doorScript.DeactivateDoor();
            }
        }
    }

    private void ChangeAnimationState(string newState)
    {
        if (currentState == newState)
            return;

        animator.Play(newState);

        currentState = newState;
    }
}
