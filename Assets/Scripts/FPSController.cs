using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed= 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 movementdir = new Vector3(hor, 0, ver);
        rb.velocity = Vector3.ClampMagnitude(movementdir, 1)* speed;

    }
}
