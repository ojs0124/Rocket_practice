using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    private AudioSource _audioSource;
    public AudioClip audioClip;

    public override void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Start()
    {
        _audioSource.clip = this.audioClip;
        _audioSource.Play();
    }

}
