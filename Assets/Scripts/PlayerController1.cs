using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public Rigidbody RB;
    public float moveSpeed = 10f;

    private float xInput;
    private float zInput;
    // Start is called before the first frame update
    void Awake()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        RB.AddForce(new Vector3(xInput, 0f, zInput)* moveSpeed);
    }
}
