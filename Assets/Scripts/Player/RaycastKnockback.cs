using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastKnockback : MonoBehaviour
{
    [SerializeField] private GameObject player = default;


    [SerializeField] private LayerMask enemy = default;
    //[SerializeField] private LayerMask bullet = default;


    private PlayerController1 playerController;
    private MoveAxis moveAxis;
    private MoveTowards moveTowards;


    private RaycastHit2D kbRightUp, kbRightDown;
    private RaycastHit2D kbDownRight, kbDownLeft;
    private RaycastHit2D kbLeftDown, kbLeftUp;
    private RaycastHit2D kbUpLeft, kbUpRight;


    private RaycastHit2D kbRight, kbDown, kbLeft, kbUp;

    private void Start()
    {
        playerController = player.GetComponent<PlayerController1>();
    }

    private void Update()
    {
        kbRightUp = Physics2D.Raycast(transform.position + new Vector3(0, 0.33f, 0), transform.right, 0.36f, enemy);
        kbRightDown = Physics2D.Raycast(transform.position + new Vector3(0, -0.33f, 0), transform.right, 0.36f, enemy);
        Debug.DrawRay(transform.position + new Vector3(0, 0.33f, 0), transform.right * 0.36f, Color.red);
        Debug.DrawRay(transform.position + new Vector3(0, -0.33f, 0), transform.right * 0.36f, Color.red);

        kbLeftDown = Physics2D.Raycast(transform.position + new Vector3(0, -0.33f, 0), -transform.right, 0.36f, enemy);
        kbLeftUp = Physics2D.Raycast(transform.position + new Vector3(0, 0.33f, 0), -transform.right, 0.36f, enemy);
        Debug.DrawRay(transform.position + new Vector3(0, -0.33f, 0), -transform.right * 0.36f, Color.green);
        Debug.DrawRay(transform.position + new Vector3(0, 0.33f, 0), -transform.right * 0.36f, Color.green);

        kbDownRight = Physics2D.Raycast(transform.position + new Vector3(0.33f, 0, 0), -transform.up, 0.36f, enemy);
        kbDownLeft = Physics2D.Raycast(transform.position + new Vector3(-0.33f, 0, 0), -transform.up, 0.36f, enemy);
        Debug.DrawRay(transform.position + new Vector3(0.33f, 0, 0), -transform.up * 0.36f, Color.cyan);
        Debug.DrawRay(transform.position + new Vector3(-0.33f, 0, 0), -transform.up * 0.36f, Color.cyan);

        kbUpLeft = Physics2D.Raycast(transform.position + new Vector3(-0.33f, 0, 0), transform.up, 0.36f, enemy);
        kbUpRight = Physics2D.Raycast(transform.position + new Vector3(0.33f, 0, 0), transform.up, 0.36f, enemy);
        Debug.DrawRay(transform.position + new Vector3(-0.33f, 0, 0), transform.up * 0.36f, Color.magenta);
        Debug.DrawRay(transform.position + new Vector3(0.33f, 0, 0), transform.up * 0.36f, Color.magenta);



        kbRight = Physics2D.Raycast(transform.position, transform.right, 0.36f, enemy);
        kbDown = Physics2D.Raycast(transform.position, -transform.up, 0.36f, enemy);
        kbLeft = Physics2D.Raycast(transform.position, -transform.right, 0.36f, enemy);
        kbUp = Physics2D.Raycast(transform.position, transform.up, 0.36f, enemy);

        Debug.DrawRay(transform.position, transform.right * 0.36f, Color.white);
        Debug.DrawRay(transform.position, -transform.up * 0.36f, Color.white);
        Debug.DrawRay(transform.position, -transform.right * 0.36f, Color.white);
        Debug.DrawRay(transform.position, transform.up * 0.36f, Color.white);



        if (playerController.wasHit == false)
        {
            if (kbRightUp || kbRightDown || kbRight)
            {
                if (kbRightUp)
                {
                    moveAxis = kbRightUp.collider.GetComponent<MoveAxis>();
                    moveTowards = kbRightUp.collider.GetComponent<MoveTowards>();
                }

                else if (kbRightDown)
                {
                    moveAxis = kbRightDown.collider.GetComponent<MoveAxis>();
                    moveTowards = kbRightDown.collider.GetComponent<MoveTowards>();
                }

                else if (kbRight)
                {
                    moveAxis = kbRight.collider.GetComponent<MoveAxis>();
                    moveTowards = kbRight.collider.GetComponent<MoveTowards>();
                }

                playerController.wasHit = true;
                playerController.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                playerController.GiveKnockback(Vector2.left);
                //GameManager.Instance.ModifyLives(1);

                if (moveAxis != null && moveAxis.isHorizontal == true)
                {
                    print("invert");
                    moveAxis.InvertAxis();
                }

                else if (moveTowards != null)
                {
                    print("movetowards");
                    moveTowards.GiveKnockback(Vector2.right);
                }
            }

            else if (kbDownRight || kbDownLeft || kbDown)
            {
                if (kbDownRight)
                {
                    moveAxis = kbDownRight.collider.GetComponent<MoveAxis>();
                    moveTowards = kbDownRight.collider.GetComponent<MoveTowards>();
                }

                else if (kbDownLeft)
                {
                    moveAxis = kbDownLeft.collider.GetComponent<MoveAxis>();
                    moveTowards = kbDownLeft.collider.GetComponent<MoveTowards>();
                }

                else if (kbDown)
                {
                    moveAxis = kbDown.collider.GetComponent<MoveAxis>();
                    moveTowards = kbDown.collider.GetComponent<MoveTowards>();
                }

                playerController.wasHit = true;
                playerController.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                playerController.GiveKnockback(Vector2.up);
                //GameManager.Instance.ModifyLives(1);

                if (moveAxis != null && moveAxis.isHorizontal == false)
                {
                    print("invert");
                    moveAxis.InvertAxis();
                }

                else if (moveTowards != null)
                {
                    print("movetowards");
                    moveTowards.GiveKnockback(Vector2.down);
                }
            }

            else if (kbLeftDown || kbLeftUp || kbLeft)
            {
                if (kbLeftDown)
                {
                    moveAxis = kbLeftDown.collider.GetComponent<MoveAxis>();
                    moveTowards = kbLeftDown.collider.GetComponent<MoveTowards>();
                }

                else if (kbLeftUp)
                {
                    moveAxis = kbLeftUp.collider.GetComponent<MoveAxis>();
                    moveTowards = kbLeftUp.collider.GetComponent<MoveTowards>();
                }

                else if (kbLeft)
                {
                    moveAxis = kbLeft.collider.GetComponent<MoveAxis>();
                    moveTowards = kbLeft.collider.GetComponent<MoveTowards>();
                }

                playerController.wasHit = true;
                playerController.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                playerController.GiveKnockback(Vector2.right);
                //GameManager.Instance.ModifyLives(1);

                if (moveAxis != null && moveAxis.isHorizontal == true)
                {
                    print("invert");
                    moveAxis.InvertAxis();
                }

                else if (moveTowards != null)
                {
                    print("movetowards");
                    moveTowards.GiveKnockback(Vector2.left);
                }
            }

            else if (kbUpLeft || kbUpRight || kbUp)
            {
                if (kbUpLeft)
                {
                    moveAxis = kbUpLeft.collider.GetComponent<MoveAxis>();
                    moveTowards = kbUpLeft.collider.GetComponent<MoveTowards>();
                }

                else if (kbUpRight)
                {
                    moveAxis = kbUpRight.collider.GetComponent<MoveAxis>();
                    moveTowards = kbUpRight.collider.GetComponent<MoveTowards>();
                }

                else if (kbUp)
                {
                    moveAxis = kbUp.collider.GetComponent<MoveAxis>();
                    moveTowards = kbUp.collider.GetComponent<MoveTowards>();
                }

                playerController.wasHit = true;
                playerController.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                playerController.GiveKnockback(Vector2.down);
                //GameManager.Instance.ModifyLives(1);

                if (moveAxis != null && moveAxis.isHorizontal == false)
                {
                    print("invert");
                    moveAxis.InvertAxis();
                }

                else if (moveTowards != null)
                {
                    print("movetowards");
                    moveTowards.GiveKnockback(Vector2.up);
                }
            }
        }
    }
}
