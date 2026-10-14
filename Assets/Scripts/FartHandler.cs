using UnityEngine;

public class FartHandler : MonoBehaviour
{
    [Header("Audio Source-------------")]
    [SerializeField] AudioSource fartSFX;
    [SerializeField] AudioSource music;

    [Header("Audio Clips-------------")]
    [SerializeField] public AudioClip fart1;
    [SerializeField] public AudioClip fart2;
    [SerializeField] public AudioClip fart3;
    [SerializeField] public AudioClip fart4;
    [SerializeField] public AudioClip fart5;
    [SerializeField] public AudioClip background;
    [SerializeField] public AudioClip scream;
    [SerializeField] public AudioClip splat;


    private void Start()
    {
        music.clip = background;
        music.Play();
    }

    public void PlayRandomFart(AudioClip clip)
    {
        fartSFX.PlayOneShot(clip);
    }
}
