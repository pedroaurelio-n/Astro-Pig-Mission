using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    /*public float moveSpeed = 5f;
    public Transform movePoint;
    public GameObject lastPos;
    public float holdTime = 0;

    float timerMove = 0;
    float maxMoveTime = 1.5f;

    public bool wasHit = false;

    Rigidbody2D rb;

    public Transform gunPos;
    public Gun gun;

    PlayerInput playerInput;
    public RaycastKnockback raycastKnockback;

    public LayerMask StopsMovement;
    public LayerMask Enemy;

    private void Awake()
    {
        playerInput = new PlayerInput();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        raycastKnockback = GetComponentInChildren<RaycastKnockback>();

        movePoint.parent = null;
        lastPos.transform.parent = null;

        playerInput.PlayerGameplay.Fire.performed += gun.Shoot;
    }

    private void Update()
    {
        if (transform.position != movePoint.position)
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        //Vector3 position = Vector3.MoveTowards(rb.position, movePoint.position, moveSpeed * Time.deltaTime);
        //rb.MovePosition(position);

        //float movementX = playerInput.PlayerGameplay.MovementX.ReadValue<float>();
        //float movementY = playerInput.PlayerGameplay.MovementY.ReadValue<float>();
        //Vector2 movementInput = new Vector2(movementX, movementY);

        if (Vector3.Distance(transform.position, movePoint.position) <= .03f)
        {
            if (Mathf.Abs(movementInput.x) >= 0.5f)
            {
                holdTime += Time.deltaTime;

                if (Mathf.Abs(movementInput.x) + holdTime > 1.20)
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(movementInput.x, 0f, 0f), .3f, StopsMovement))
                    {
                        lastPos.transform.position = transform.position;
                        movePoint.position += new Vector3(movementInput.x, 0f, 0f);
                    }
                }
            }

            else if (Mathf.Abs(movementInput.y) >= 0.5f)
            {
                holdTime += Time.deltaTime;

                if (Mathf.Abs(movementInput.y) + holdTime > 1.20)
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, movementInput.y, 0f), .3f, StopsMovement))
                    {
                        lastPos.transform.position = transform.position;
                        movePoint.position += new Vector3(0f, movementInput.y, 0f);
                    }
                }
            }

            else
            {
                holdTime = 0;
            }


            if (transform.position != movePoint.position)
            {
                timerMove += Time.deltaTime;

                if (timerMove >= maxMoveTime)
                    transform.position = lastPos.transform.position;
            }

            else
                timerMove = 0;


            //print(timerMove);

            /*if (transform.position == movePoint.position && raycastKnockback.raycastHit == true)
            {
                wasHit = false;
                raycastKnockback.raycastHit = false;
            }



            if (movementInput.x > 0)
            {
                gunPos.localRotation = Quaternion.Euler(0, 0, 0);
            }

            else if (movementInput.x < 0)
            {
                gunPos.localRotation = Quaternion.Euler(0, 0, 180);
            }

            else if (movementInput.y > 0)
            {
                gunPos.localRotation = Quaternion.Euler(0, 0, 90);
            }

            else if (movementInput.y < 0)
            {
                gunPos.localRotation = Quaternion.Euler(0, 0, 270);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.collider.tag)
        {
            case "Items":
                Destroy(collision.gameObject);
                //print("a");
                GameManager.Instance.itemsRemaining -= 1;
                GameManager.Instance._score += 10;
                break;

            case "Enemy":
                //collision.collider.gameObject.GetComponent<MoveAxis>().InvertAxis();
                //GameManager.Instance.ModifyLives(1);
                //movePoint.position = raycastKnockback.GetKnockbackDirection();
                //print(raycastKnockback.GetKnockbackDirection());
                break;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Switch") && playerInput.PlayerGameplay.Interaction.triggered)
        {
            collision.transform.gameObject.GetComponent<Switch>().ActivateSwitch();
            print("test");
        }
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }*/
}
