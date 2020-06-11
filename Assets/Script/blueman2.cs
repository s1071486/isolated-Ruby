﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueman2 : MonoBehaviour
{
    // Start is called before the first frame update
    int hp;
    public const int maxHealth = 100;

    public int currentHealth = maxHealth;
    void Start()
    {
        hp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0.5f, 0) * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Bullet")
        {
            hp--;

            Destroy(col.gameObject);
            if (hp == 0)
            {
                Destroy(gameObject);
            }
        }
        if (col.tag == "player")
        {
            Destroy(gameObject);
            currentHealth = currentHealth - 10;
        }
    }
}