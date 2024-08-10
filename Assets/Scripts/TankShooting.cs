﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TankShooting : MonoBehaviour
{
    public Rigidbody m_Shell;
    public Transform m_FireTransform;
    public float m_LaunchForce = 30f;
    public AudioClip impact;
    private bool m_CanShoot;


    void Fire()
    {
        Rigidbody shellInstance = Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation); shellInstance.velocity = m_LaunchForce * m_FireTransform.forward;
    }
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Fire();
        }


    }


}


