﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatilhoCod : MonoBehaviour
{

    public bool liberaRot;
    public GameObject ima;


    // Start is called before the first frame update
    void Start()
    {
        liberaRot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(liberaRot == true)
        {
            ima.gameObject.transform.Rotate(new Vector3(0, 0, 20 * Time.deltaTime));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ave"))
        {
            liberaRot = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ave"))
        {
            liberaRot = false;
        }
    }
}