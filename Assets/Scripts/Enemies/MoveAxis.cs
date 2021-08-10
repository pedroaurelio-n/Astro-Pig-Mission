using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAxis : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private Vector3 directionAxis = default;


    [SerializeField] private float colliderAxisX = default;
    [SerializeField] private float colliderAxisY = default;


    private RaycastHit2D moveRaycast;
    private RaycastHit2D colliderRaycast1, colliderRaycast2, colliderRaycast3, colliderRaycast4;


    [SerializeField] private Transform movePoint = null;
    [SerializeField] private LayerMask StopsMovement = default;
    [SerializeField] private LayerMask FrozenEnemy = default;


    private EnemyController enemycontroller;
    private Rigidbody2D rb;
    private Animator animator;


    private int moveAxisAnimationInt = 1;
    private string currentState;


    public bool isHorizontal;

    private void Start()
    {
        movePoint.parent = null;

        enemycontroller = GetComponent<EnemyController>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        moveRaycast = Physics2D.Raycast(transform.position, directionAxis, 30f, StopsMovement);
        Debug.DrawRay(transform.position, directionAxis * 30f, Color.green);

        colliderRaycast1 = Physics2D.Raycast(transform.position + new Vector3(colliderAxisX, colliderAxisY, 0), directionAxis, 0.6f, StopsMovement);
        Debug.DrawRay(transform.position + new Vector3(colliderAxisX, colliderAxisY, 0), directionAxis * 0.6f, Color.blue);

        colliderRaycast2 = Physics2D.Raycast(transform.position + new Vector3(-colliderAxisX, -colliderAxisY, 0), directionAxis, 0.6f, StopsMovement);
        Debug.DrawRay(transform.position + new Vector3(-colliderAxisX, -colliderAxisY, 0), directionAxis * 0.6f, Color.blue);

        colliderRaycast3 = Physics2D.Raycast(transform.position + new Vector3(colliderAxisX, colliderAxisY, 0), directionAxis, 0.6f, FrozenEnemy);
        Debug.DrawRay(transform.position + new Vector3(colliderAxisX, colliderAxisY, 0), directionAxis * 0.6f, Color.blue);

        colliderRaycast4 = Physics2D.Raycast(transform.position + new Vector3(-colliderAxisX, -colliderAxisY, 0), directionAxis, 0.6f, FrozenEnemy);
        Debug.DrawRay(transform.position + new Vector3(-colliderAxisX, -colliderAxisY, 0), directionAxis * 0.6f, Color.blue);

        movePoint.position = moveRaycast.point;


        if (!enemycontroller.isFrozen)
        {
            animator.speed = 1;

            moveAxisAnimationInt = CheckVelocity();

            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

            switch (moveAxisAnimationInt)
            {
                case 1:
                    ChangeAnimationState("MoveAxis_up");
                    break;

                case 2:
                    ChangeAnimationState("MoveAxis_right");
                    break;

                case 3:
                    ChangeAnimationState("MoveAxis_down");
                    break;

                case 4:
                    ChangeAnimationState("MoveAxis_left");
                    break;
            }

            if (moveRaycast.distance <= 0.5f || colliderRaycast1 || colliderRaycast2 || colliderRaycast3 || colliderRaycast4)
            {
                InvertAxis();
            }
        }

        else
        {
            movePoint.position = transform.position;
            animator.speed = 0;
        }

        
        
        if (directionAxis == new Vector3(1, 0) || directionAxis == new Vector3(-1, 0))
            isHorizontal = true;

        else
            isHorizontal = false;
    }

    public void InvertAxis()
    {
        directionAxis = directionAxis * (-1);
    }


    private int CheckVelocity()
    {
        if (Mathf.Abs(directionAxis.x) >= Mathf.Abs(directionAxis.y))
        {
            if (directionAxis.x > 0)
            {
                return 2;
            }

            else
            {
                return 4;
            }
        }

        else
        {
            if (directionAxis.y > 0)
            {
                return 1;
            }

            else
            {
                return 3;
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
