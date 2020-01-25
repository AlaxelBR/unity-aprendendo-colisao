using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFoguete : MonoBehaviour
{
    public float vel = 6.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Captura de teclas
        /*
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, vel * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -vel * Time.deltaTime, 0));
        }
        */


        //Setas de teclado
        /*
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h * (Time.deltaTime) * vel, v * (Time.deltaTime) * vel, 0));
        */

        //mouse X e Y
        /*
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        transform.Translate(new Vector3(h * (Time.deltaTime) * vel, v * (Time.deltaTime) * vel, 0));
        */

                
        
    }

}