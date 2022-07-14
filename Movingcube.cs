using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingcube : MonoBehaviour
{
    // Start is called before the first frame update
    public float X { get; private set; }
    public float Z { get; private set; }
    public float speed;

    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        X = Z = 0f;

        X = Input.GetAxis("Horizontal");
        Z = Input.GetAxis("Vertical");

        float xSpeed = X * speed;
        float zSpeed = Z * speed;
        _rigidbody.velocity = new Vector3(xSpeed, 0f, zSpeed);
        
    }
}
