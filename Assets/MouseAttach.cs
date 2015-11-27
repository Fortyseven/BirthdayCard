using UnityEngine;
using System.Collections;

public class MouseAttach : MonoBehaviour
{
    private Vector3 _mousePos;
    private bool _start_trigger;

    void Start()
    {
        Cursor.visible = false;
        _start_trigger = false;
        Update();
        //var part = GetComponentInChildren<ParticleSystem>();
        //part.simulationSpace = ParticleSystemSimulationSpace.World;        
        //_mousePos = Input.mousePosition;
        // Invoke( "useWorld", 0.5f );
    }

    //public void useWorld()
    //{
    //    Debug.Log("unlock");
    //    var part = GetComponentInChildren<ParticleSystem>();
    //    part.simulationSpace = ParticleSystemSimulationSpace.World;
    //}

    private void Update()
    {
        var new_mouse_pos = Input.mousePosition;

        //if ( !_start_trigger ) {
        //    Debug.Log(new_mouse_pos + " <- " + _mousePos );
        //    if ( Mathf.Abs(new_mouse_pos.y - _mousePos.y) > 10.0f ) {
        //        var part = GetComponentInChildren<ParticleSystem>();
        //        part.simulationSpace = ParticleSystemSimulationSpace.World;
        //        _start_trigger = true;
        //    }

        //    _mousePos = new_mouse_pos;
        //}
        //else {
        transform.position = Camera.main.ScreenToWorldPoint( new Vector3( new_mouse_pos.x, new_mouse_pos.y ) );
        //}
    }
}
