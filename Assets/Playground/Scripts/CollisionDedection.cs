using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDedection : MonoBehaviour
{
    private GameObject objectToDelete;
    private GameObject bullet;
    private static int counter = 0;
    void OnCollisionEnter(Collision collision)
    {
       // Debug.Log("------>>>>  @ CollisionDedection +collision.gameObject.tag: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Zombie")
        {
        
            objectToDelete = GameObject.Find(collision.gameObject.name);
            //objectToDelete.GetComponent<Renderer>().material.color  = UnityEngine.Random.ColorHSV(0.002f, 0.2f);
            bullet = GameObject.Find("Bullet");
            Debug.Log(" Try FInd BUllet + gameObject :   " + bullet);
            counter += 1; 
            Debug.Log("Counter: " + counter);
            //ChangeObjCollor(bullet);
            Destroy(objectToDelete);
            TryToDestroy(bullet);
        }
        
    }
    private void TryToDestroy(GameObject ob)
        {   
            var exp = GetComponent<ParticleSystem>();
            exp.Play();
            Destroy(ob, exp.duration);
            Destroy(ob);
        }
    
    /*private void ChangeObjCollor(GameObject ob)
        {
            var objectRd = ob.GetComponent<Renderer>();
            Debug.Log(" ----->>>>   @ ChangeColor()  renderer: " + objectRd.material);
            objectRd.material.SetColor("_Color", Color.red);
            //gameObject.GetComponent<Renderer>().material.color  = UnityEngine.Random.ColorHSV(0.002f, 0.2f);
            

            
        }*/

}
