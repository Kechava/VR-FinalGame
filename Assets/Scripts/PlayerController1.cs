using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public Rigidbody r;
    public float Speed = 45f;

    private float xInput;
    private float zInput;
    // Start is called before the first frame update
    void Awake()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        r.AddForce(new Vector3(xInput, 0f, zInput)* Speed);
    }
}
