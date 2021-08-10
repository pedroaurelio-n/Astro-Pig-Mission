using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    #region Singleton
    public static AudioController Instance;

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
    }

    public void PlayAudio(int index)
    {
        audioSource.PlayOneShot(audioClips[index]);
    }
}
