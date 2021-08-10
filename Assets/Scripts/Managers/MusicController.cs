using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    #region Singleton
    public static MusicController Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
            Destroy(gameObject);
    }
    #endregion

    [SerializeField] private List<AudioClip> audioClips = default;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = audioClips[0];
        audioSource.Play();
    }


    public void ChangeMusic(int index)
    {
        if ((index == 0 || index == 1 || index == 12) && audioSource.clip != audioClips[0])
        {
            audioSource.clip = audioClips[0];
            audioSource.Play();
        }

        else if ((index != 0 && index != 1 && index != 12) && audioSource.clip != audioClips[1])
        {
            audioSource.clip = audioClips[1];
            audioSource.Play();
        }
    }
}
