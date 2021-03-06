﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject, 3);
        Invoke("OOF", 2);
        //Debug.Log(Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        GoDown();
    }


    public void GoDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OOF"))
        {
            GameManager gm = GameObject.FindObjectOfType<GameManager>();

            gm.combo = 0;
            gm.ShowQuality(5);
            Destroy(this.gameObject);
        }
            
    }
}
