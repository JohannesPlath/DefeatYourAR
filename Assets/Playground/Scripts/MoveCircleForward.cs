using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircleForward : MonoBehaviour
{

    public float speed = 0.05f;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float speedRotation = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));  
        transform.Rotate(_rotation * (speedRotation * Time.deltaTime));
    }
}
