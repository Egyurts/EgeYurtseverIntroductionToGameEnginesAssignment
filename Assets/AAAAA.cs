using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAAA : MonoBehaviour
{
    
    public float speed = 0.5f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
