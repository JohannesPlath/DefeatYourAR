using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDedection : MonoBehaviour
{
    private GameObject objectToDelete;
    private GameObject bullet;
    private static int counter = 0;
    public GameObject exp;
    void OnCollisionEnter(Collision collision)
    {
       // Debug.Log("------>>>>  @ CollisionDedection +collision.gameObject.tag: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Zombie")
        {
            objectToDelete = GameObject.Find(collision.gameObject.name);
            bullet = GameObject.Find("Bullet");
            //Debug.Log(" Try FInd BUllet + gameObject :   " + bullet);
            counter += 1; 
            //Debug.Log("Counter: " + counter);
            TryToDestroy(objectToDelete);
            TryToDestroy(bullet);
            Explosion(bullet);
        }
    }
    private void TryToDestroy(GameObject ob)
        {   
            Destroy(ob);
        }

    private void Explosion(GameObject ob)
    {
        GameObject _exp = Instantiate(this.exp, transform.position, transform.rotation);
        Destroy(_exp, 1.5f);
        Destroy(ob);
        
    }
    
}
