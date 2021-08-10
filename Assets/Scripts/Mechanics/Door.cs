using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [HideInInspector] public bool isActive;
    [HideInInspector] public bool isActivatedBySwitch;
    private Collider2D doorCollider;
    private Animator animator;
    private SpriteRenderer sprite;
    [SerializeField] private bool isHorizontal = default;
    [SerializeField] private bool invertHorizontal = default;

    private string currentState;

    private void Start()
    {
        doorCollider = GetComponentInChildren<Collider2D>();
        animator = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        isActive = false;

        if (isHorizontal)
        {
            if (invertHorizontal)
                ChangeAnimationState("Door_H_Up");

            else
                ChangeAnimationState("Door_H");
        }

        else
            ChangeAnimationState("Door_V");
    }

    public void ActivateDoor()
    {
        isActive = true;
        //transform.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z + 90);
        
        if (isHorizontal)
            ChangeAnimationState("Door_V");

        else
        {
            if (invertHorizontal)
                ChangeAnimationState("Door_H_Up");

            else
                ChangeAnimationState("Door_H");
        }

        doorCollider.enabled = false;
        sprite.enabled = false;
        if (!isActivatedBySwitch)
            AudioController.Instance.PlayAudio(6);
    }

    public void DeactivateDoor()
    {
        if (!isActivatedBySwitch)
        {
            isActive = false;

            if (isHorizontal)
            {
                if (invertHorizontal)
                    ChangeAnimationState("Door_H_Up");

                else
                    ChangeAnimationState("Door_H");
            }

            else
                ChangeAnimationState("Door_V");

            //transform.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z - 90);
            doorCollider.enabled = true;
            sprite.enabled = true;
            AudioController.Instance.PlayAudio(5);
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
