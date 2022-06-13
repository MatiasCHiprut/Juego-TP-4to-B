﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfetiSpawn : MonoBehaviour
{
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }
    }
    

    void OnCollision(Collision col)
    {
        if (col.gameObject.name == "ConfetiCollisioner")
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }
    }
}