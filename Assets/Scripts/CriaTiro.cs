using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaTiro : MonoBehaviour
{
    public GameObject tiro;
    public GameObject canhao;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(tiro, new Vector3(canhao.transform.position.x, canhao.transform.position.y, canhao.transform.position.z), canhao.transform.rotation);
        }
    }
}
