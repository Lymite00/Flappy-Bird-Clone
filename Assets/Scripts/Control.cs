using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount;
    public bool isDead=false;
    public GameManager _Manager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&&!isDead)
        {
            rb.velocity=Vector2.up*jumpAmount;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pipes"))
        {
            isDead = true;

        }else if (collision.gameObject.CompareTag("zemin"))
        {
            isDead = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("score"))
        {
            _Manager.updateScore();
        }
    }
}
