using UnityEngine;
using System.Collections;

public class Firework_Launcher : MonoBehaviour
{

    public GameObject FireworkPrefab;

    private const float TIMER_MAX = 6.0f;
    private const float TIMER_MIN = 1.5f;

    private float _last_launch_timeout;

    private void Start()
    {       
        Reset();
        _last_launch_timeout = TIMER_MIN;
    }

    // Update is called once per frame
    void Update()
    {
        _last_launch_timeout -= Time.deltaTime;
        if ( _last_launch_timeout <= 0 ) {
            LaunchFirework();
            Reset();
        }
    }

    void LaunchFirework()
    {
        Instantiate( FireworkPrefab, Vector3.zero, Quaternion.AngleAxis( 90.0f, Vector3.left ) );
    }

    void Reset()
    {
        _last_launch_timeout = Random.Range( TIMER_MIN, TIMER_MAX );
    }

}
