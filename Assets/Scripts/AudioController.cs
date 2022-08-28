using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    bool soundActive = true;
    [SerializeField] AudioSource audioSource;

    public void SwitchSound()
    {
        audioSource.gameObject.SetActive(soundActive);
        soundActive = !soundActive;
    }

}
