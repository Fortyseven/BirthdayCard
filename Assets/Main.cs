using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Escape ) ) {
            Application.Quit();
        }

        if ( Input.GetKeyDown( KeyCode.M ) ) {
            GetComponent<AudioSource>().mute = !GetComponent<AudioSource>().mute;
        }

    }
}
