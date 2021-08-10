using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float freezeTimer = 0;
    private float freezeCount = 0;


    [SerializeField] private GameObject frozenSprite = null;
    [SerializeField] private GameObject frozenText = default;
    public bool isFrozen;


    private Rigidbody2D rb;
    private GameObject tempFrozen;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isFrozen)
        {            
            if (freezeCount <= freezeTimer)
            {
                freezeCount += Time.deltaTime;
            }

            else
            {
                isFrozen = false;
                freezeCount = 0;
                rb.velocity = Vector2.zero;
                Destroy(tempFrozen);
                gameObject.tag = "Enemy";
                gameObject.layer = 10;
            }
        }
    }


    private void FreezeEnemy()
    {
        isFrozen = true;
        gameObject.layer = 14;
        rb.velocity = Vector2.zero;
        tempFrozen = Instantiate(frozenSprite, transform.position, Quaternion.identity, transform);
        gameObject.tag = "FrozenEnemy";

        ShowFrozenText();
    }

    private void ShowFrozenText()
    {
        Instantiate(frozenText, transform.position + new Vector3(0, 1f, 0), Quaternion.identity, transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isFrozen)
        {
            if (collision.CompareTag("Bullet"))
            {
                FreezeEnemy();
            }
        }
    }
}
