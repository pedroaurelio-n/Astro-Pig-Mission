using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController1 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float knockbackForce = default;


    [SerializeField] private Transform gunPos = default;
    [SerializeField] private Gun gun = default;


    [HideInInspector] public Vector2 movementInput;
    private float movementX, movementY;


    private Rigidbody2D rb;
    private PlayerInput playerInput;

    [HideInInspector] public int animationIntDirection = 1;

    public bool wasHit = false;
    public bool isShooting = false;


    private void Awake()
    {
        playerInput = new PlayerInput();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        playerInput.PlayerGameplay.Movement.performed += ctx => movementX = ctx.ReadValue<Vector2>().x;
        playerInput.PlayerGameplay.Movement.performed += ctx => movementY = ctx.ReadValue<Vector2>().y;

        playerInput.PlayerGameplay.Fire.performed += gun.Shoot;
        //playerInput.PlayerGameplay.Restart.performed += RestartGame;
        playerInput.PlayerGameplay.Pause.performed += PauseInput;
    }

    private void Update()
    {
        movementInput = new Vector2(movementX, movementY);



        switch (animationIntDirection)
        {
            case 1:
                gunPos.localRotation = Quaternion.Euler(0, 180, 90);
                break;

            case 2:
                gunPos.localRotation = Quaternion.Euler(0, 0, 0);
                break;

            case 3:
                gunPos.localRotation = Quaternion.Euler(0, 180, 270);
                break;

            case 4:
                gunPos.localRotation = Quaternion.Euler(0, 180, 0);
                break;
        }



        if (GameManager.Instance.isGameOver == true)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(movementInput * moveSpeed, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            /*case "Items":
                Destroy(collision.gameObject);
                GameManager.Instance._score += 10;
                GameManager.Instance.ModifyItems(-1);
                AudioController.Instance.PlayAudio(0);
                break;*/

            case "PuzzleArea":
                GameManager.Instance.onPuzzle = true;
                break;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Switch") && playerInput.PlayerGameplay.Interaction.triggered)
        {
            collision.transform.gameObject.GetComponent<Switch>().ActivateSwitch();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "PuzzleArea":
                GameManager.Instance.onPuzzle = false;
                break;
        }
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public void GiveKnockback(Vector2 direction)
    {
        rb.AddForce(direction * knockbackForce, ForceMode2D.Impulse);
        GameManager.Instance.ModifyLives(1);

        if (GameManager.Instance.isGameOver)
            AudioController.Instance.PlayAudio(1);

        else
            AudioController.Instance.PlayAudio(2);
    }

    private void RestartGame(InputAction.CallbackContext ctx)
    {
        GameManager.Instance.RestartGame();
    }

    private void PauseInput(InputAction.CallbackContext ctx)
    {
        if (!GameManager.Instance.isGamePaused)
            GameManager.Instance.PauseGame();

        else
            GameManager.Instance.ResumeGame();
    }
}
