using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Source-----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-----Audio Clip-----")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip explode;
    public AudioClip itemPickUp;

    public AudioClip dropBomb;

    public AudioClip death2;

    [Header("-----SFX Volumes-----")]
    [Range(0f, 1f)] public float deathVolume = 1f;
    [Range(0f, 1f)] public float explodeVolume = 1f;
    [Range(0f, 1f)] public float itemPickUpVolume = 1f;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip, float volume = 1f)
    {
        SFXSource.PlayOneShot(clip, volume);
    }
    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void StopAllSFX()
    {
        SFXSource.Stop();
    }

    
}