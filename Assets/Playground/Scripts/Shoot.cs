using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float force = 700f;
    [SerializeField] private float speedUp = 10.0f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        /*if (Input.GetKeyUp("space")){
            Debug.Log("space has Arrived ");
            rb.isKinematic = false;
            rb.AddForce(transform.right * force * -1.0f);
        }
        if (Input.GetKeyDown("c")){
            Debug.Log("Key c has arrived");
            rb.isKinematic = false;
            rb.AddForce(transform.right * force * -1.0f);
            }*/
        /*
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.MovePosition(transform.position + direction * (Time.deltaTime * speed));        
        */
        
    }

    public void ShootBullet()
    {
        //Debug.Log(" @  ShootBullet() + transform.right * force * -1.0f "  + transform.right * force * -1.0f +  "transform.up * speedUp" + transform.up * speedUp);
        rb.isKinematic = false;
        rb.AddForce(transform.forward * force + transform.up * speedUp);
        GameObject bullet = GameObject.Find("Bullet");
        Destroy(bullet, 3f);
    }
}
