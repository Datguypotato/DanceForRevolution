using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ActivateSound : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void PlaySound()
    {
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
    }
}
