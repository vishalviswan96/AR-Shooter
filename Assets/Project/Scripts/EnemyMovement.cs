﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);
        transform.LookAt(Camera.main.transform.position);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
