﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronPutina : MonoBehaviour
{
    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}