﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationCielo : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadRotacion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*velocidadRotacion);
    }
}
