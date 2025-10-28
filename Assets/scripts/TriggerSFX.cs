using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource myAudioSource;
    
    void OnTriggerEnter(Collider other)
    {
        myAudioSource.Play();
    }

    void OnTriggerExit(Collider other)
    {
        myAudioSource.Pause();
    }


}

