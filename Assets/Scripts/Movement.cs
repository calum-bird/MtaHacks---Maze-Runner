using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Move();
    }

    // Update is called once per frame
    void Update()
    {
        //Move();
        float vertical = Input.GetAxis("Vertical") * speed;
        float horizontal = Input.GetAxis("Horizontal") * speed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        vertical *= Time.deltaTime;
        horizontal *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(horizontal, vertical, 0);
    }
}