using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Vector3 start;
    public bool hit = false;
    public void resetpos()
    {
        transform.position = start;
    }

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;

    }

    // Update is called once per frame
    void OnCollisionEnter (Collision col)
    {
        if (col. gameObject.tag == "BowlingPin")
        {
           
            hit = true;
        }

        
    }


}
