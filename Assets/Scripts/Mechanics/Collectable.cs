using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private GameObject collectParticles;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.Instance._score += 10;
            GameManager.Instance.ModifyItems(-1);
            AudioController.Instance.PlayAudio(0);
            GameObject temp = Instantiate(collectParticles, transform.position, Quaternion.identity);
        }
    }
}
