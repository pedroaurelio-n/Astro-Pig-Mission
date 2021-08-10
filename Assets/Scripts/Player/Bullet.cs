using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = default;

    [SerializeField] private GameObject collisionBurstGO = default;


    private void Update()
    {
        transform.position += transform.right * bulletSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject temp = Instantiate(collisionBurstGO, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
