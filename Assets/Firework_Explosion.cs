﻿using UnityEngine;
using System.Collections;

public class Firework_Explosion : MonoBehaviour
{

    private ParticleSystem _particle_system;
    private ParticleAnimator _particle_animator;
    private int _last_particle_count = 0;
    private AudioSource _audio_source;

    private Vector3 _pos;

    void Start()
    {
        _particle_system = GetComponent<ParticleSystem>();

        _audio_source = GetComponent<AudioSource>();

        transform.position = new Vector3( Random.Range( -2.5f, 2.5f ), -1.97f, 0.38f );
        transform.Rotate( Vector3.up, Random.Range( -20.0f, 20.0f ) );

        _particle_system.gravityModifier = Random.Range( 0, 0.5f );

        //ModifyColor();
    }

    //private void ModifyColor()
    //{

    //    Renderer rend = GetComponentsInChildren<Renderer>()[ 2 ];
    //    //Material mat = new Material( rend.material );


    //    //mat.= Color.red;
    //    //Debug.Log( mat.name );
    //    //rend.material = mat;

    //    rend.sharedMaterials[ 0 ].color = Color.red;


    //}

    // Update is called once per frame
    void Update()
    {
        var count = _particle_system.particleCount;

        if ( count < _last_particle_count ) {
            _audio_source.pitch = Random.Range( 0.25f, 1.0f );
            _audio_source.Play();
        }
        //else {
        //    if ( count > _last_particle_count ) {
        //        Debug.Log( "I live " + count );
        //    }
        //}

        _last_particle_count = count;
    }
}