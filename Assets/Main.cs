using UnityEngine;

public class Main : MonoBehaviour
{
    public void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Escape ) ) {
            Application.Quit();
        }

        if ( Input.GetKeyDown( KeyCode.M ) ) {
            GetComponent<AudioSource>().mute = !GetComponent<AudioSource>().mute;
        }
    }
}
