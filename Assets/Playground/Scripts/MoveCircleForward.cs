using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircleForward : MonoBehaviour
{

    
    public float speed = 0.05f;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float speedRotation = 25.0f;
    [SerializeField] private Rigidbody rb;

    //[SerializeField] private Vector3 _moveDir;
    // für AI
    //[SerializeField] private float aggroRange = 10;
    //[SerializeField] public GameObject cannon;

    //private Animator anim;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        
        //cannon = GameObject.FindGameObjectWithTag("Cannon");
        // anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (cannon != null)
        {
            float dist = Vector3.Distance(transform.position, cannon.transform.position);


            if (dist <= aggroRange)
            {
                transform.LookAt((cannon.transform));
                rb.AddRelativeForce(transform.forward * (Time.deltaTime * speed * 1.3f), ForceMode.Force);
            }
            else
            {
                //rb.AddRelativeForce(Vector3.forward * (Time.deltaTime * speed));
                transform.Translate(Vector3.forward * (Time.deltaTime * speed));
                transform.Rotate(_rotation * (speedRotation * Time.deltaTime));

            }
        }
        else*/
        {   
            //rb.MovePosition(transform.position + _moveDir * (Time.deltaTime * speed));
            //rb.AddForce(Vector3.forward * (Time.deltaTime * speed));
            //rb.AddRelativeForce(Vector3.forward * (Time.deltaTime * speed));
            transform.Translate(Vector3.forward * (Time.deltaTime * speed));  
            transform.Rotate(_rotation * (speedRotation * Time.deltaTime));
            Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //rb.MovePosition(transform.position + direction * (Time.deltaTime * speed));       
        }
    }
    
   
}
