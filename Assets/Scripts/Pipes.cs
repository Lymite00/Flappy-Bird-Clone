using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        Destroy(gameObject,5f);
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
