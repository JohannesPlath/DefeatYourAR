using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircleForward : MonoBehaviour
{

    
    public float speed = 0.05f;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float speedRotation = 25.0f;

    [SerializeField] private Rigidbody rb;
    //private Animator anim;
    void Start()
    {
       // anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        //rb.AddRelativeForce(Vector3.forward * (Time.deltaTime * speed));
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));  
        transform.Rotate(_rotation * (speedRotation * Time.deltaTime));
    }
}
