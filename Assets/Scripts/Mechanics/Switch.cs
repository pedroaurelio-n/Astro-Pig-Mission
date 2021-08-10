using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private Door doorScript = default;
    [SerializeField] private bool isHorizontal = default;


    private Animator animator;


    private bool isActive;
    private string currentState;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ActivateSwitch()
    {
        if (isActive == false)
        {
            if (isHorizontal)
            {
                ChangeAnimationState("Lever_Side_Down");
                AudioController.Instance.PlayAudio(7);

                isActive = true;
                doorScript.isActivatedBySwitch = true;

                if (!doorScript.isActive)
                    doorScript.ActivateDoor();

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
