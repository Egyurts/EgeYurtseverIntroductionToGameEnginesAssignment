using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAAB : MonoBehaviour
{

    public float speed = 5f;
    void Start()
    {

    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}



