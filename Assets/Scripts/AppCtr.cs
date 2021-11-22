using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Platform;

public class AppCtr : MonoBehaviour
{

    void Start()
    {



    }

    public GameObject inviteUI;
    public GameObject kim;
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            kim.SetActive(false);
            inviteUI.SetActive(true);
        }

        if (OVRInput.Get(OVRInput.Button.One))
        {
            inviteUI.SetActive(false);
            kim.SetActive(true);
        }
    }

    public Animator aniCtr;
    public void PlayReaction()
    {
        aniCtr.Play("React");
    }

    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public void PlayAudioClip (int index)
    {
        audioSource.clip = audioClips[index];
        audioSource.Play();
    }
}
