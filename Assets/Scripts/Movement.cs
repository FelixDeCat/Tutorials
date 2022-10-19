using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    Vector3 dir = new Vector3(0,0,0); 
    void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");
        transform.position = transform.position + dir.normalized * speed * Time.deltaTime;
    }
}
