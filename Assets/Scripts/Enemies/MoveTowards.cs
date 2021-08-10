using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    [SerializeField] private float speedMultiplier = 2f;
    [SerializeField] private float knockbackForce = default;
    [SerializeField] private float followRadius = default;


    private Vector3 direction;
    private float speedMin = 300f;
    private float speedMax = 670f;
    private float moveSpeed = default;


    [SerializeField] private Transform target = default;


    [SerializeField] private Transform restPoint = default;


    private Rigidbody2D rb;
    private Animator animator;
    private EnemyController enemycontroller;


    private string currentState;
    private bool isFollowing = false;
    private bool isAlert = false;

    private void Start()
    {
        restPoint.parent = null;

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        enemycontroller = GetComponent<EnemyController>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, followRadius);
    }

    private void Update()
    {
        if (!GameManager.Instance.isGameOver)
        {
            moveSpeed = Mathf.Clamp(speedMultiplier / (Vector2.Distance(target.position, transform.position) * 0.53f), speedMin, speedMax);

            if (enemycontroller.isFrozen)
            {
                animator.speed = 0;
            }

            if (!GameManager.Instance.onPuzzle)
            {
                if (target != null && Vector2.Distance(target.position, transform.position) < followRadius)
                {
                    if (isFollowing == false)
                    {
                        StartCoroutine(AlertAnimation());
                        isFollowing = true;
                    }

                    else
                    {
                        direction = new Vector2(target.position.x - transform.position.x, target.position.y - transform.position.y);
                        Debug.DrawRay(transform.position, direction, Color.red);

                        if (!enemycontroller.isFrozen && !isAlert)
                        {
                            animator.speed = 1;
                            StartCoroutine(FollowAnimation());
                            rb.AddForce(direction.normalized * moveSpeed * Time.deltaTime);
                        }

                        else if (enemycontroller.isFrozen)
                        {
                            animator.speed = 0;
                        }
                    }
                }

                else if (target == null || Vector2.Distance(target.position, transform.position) > followRadius && !enemycontroller.isFrozen)
                {
                    StopAllCoroutines();
                    ChangeAnimationState("MoveTowards_Idle");
                    animator.speed = 1;
                    isFollowing = false;
                    isAlert = false;

                    if (enemycontroller.isFrozen)
                    {
                        animator.speed = 0;
                    }
                }
            }

            else
            {
                if (Vector2.Distance(restPoint.position, transform.position) < 7)
                {
                    if (isFollowing == false)
                    {
                        StartCoroutine(AlertAnimation());
                        isFollowing = true;
                    }

                    else
                    {
                        direction = new Vector2(restPoint.position.x - transform.position.x, restPoint.position.y - transform.position.y);
                        Debug.DrawRay(transform.position, direction, Color.red);

                        if (!enemycontroller.isFrozen && Vector2.Distance(restPoint.position, transform.position) > 0.5 && !isAlert)
                        {
                            animator.speed = 1;
                            StartCoroutine(FollowAnimation());
                            rb.AddForce(direction.normalized * moveSpeed * Time.deltaTime);
                        }

                        else if (enemycontroller.isFrozen)
                        {
                            animator.speed = 0;
                        }
                    }
                }

                else if (Vector2.Distance(restPoint.position, transform.position) > followRadius && !enemycontroller.isFrozen)
                {
                    StopAllCoroutines();
                    ChangeAnimationState("MoveTowards_Idle");
                    animator.speed = 1;
                    isFollowing = false;
                    isAlert = false;
                }
            }
        }

        else
        {
            StopAllCoroutines();
            target = null;
            ChangeAnimationState("MoveTowards_Idle");
            animator.speed = 1;
            isFollowing = false;
            isAlert = false;
        }
    }

    public void GiveKnockback(Vector2 direction)
    {
        print("knockbackForce");
        rb.AddForce(direction * knockbackForce, ForceMode2D.Impulse);
    }

    private void ChangeAnimationState(string newState)
    {
        if (currentState == newState)
            return;

        animator.Play(newState);
        currentState = newState;
    }

    private IEnumerator AlertAnimation()
    {
        isAlert = true;
        animator.speed = 1;
        if (!enemycontroller.isFrozen)
            ChangeAnimationState("MoveTowards_Alert");
        yield return new WaitForSeconds(1f);
        isAlert = false;
    }

    private IEnumerator FollowAnimation()
    {
        if (isFollowing == true)
        {
            ChangeAnimationState("MoveTowards_Follow");
        }

        yield return new WaitForSeconds(0.3f);
    }
}
