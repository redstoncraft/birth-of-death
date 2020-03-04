﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEffect : MonoBehaviour
{
    Material material;

    bool isDissolving = false;
    float fade = 1f;

    [SerializeField]
    KeyCode dissolve;
    [SerializeField]
    KeyCode dissolvePS;
   

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(dissolve))
        {
            isDissolving = true;
        }

        if (isDissolving)
        {
            fade -= Time.deltaTime;

            if (fade <= 0f)
            {
                fade = 0f;
                isDissolving = false;
            }

            material.SetFloat("_Fade", fade);
        }

        if (Input.GetKey(dissolvePS))
        {
            isDissolving = true;
        }

        if (isDissolving)
        {
            fade -= Time.deltaTime;

            if (fade <= 0f)
            {
                fade = 0f;
                isDissolving = false;
            }

            material.SetFloat("_Fade", fade);
        }

        

    }
}
