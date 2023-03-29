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
            //objectToDelete.GetComponent<Renderer>().material.color  = UnityEngine.Random.ColorHSV(0.002f, 0.2f);
            bullet = GameObject.Find("Bullet");
            Debug.Log(" Try FInd BUllet + gameObject :   " + bullet);
            counter += 1; 
            Debug.Log("Counter: " + counter);
            //ChangeObjCollor(bullet);
            Destroy(objectToDelete);
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
        //var exp = GetComponent<ParticleSystem>();
        //exp.Play();
        Destroy(_exp, 1.5f);
        Destroy(ob);
        /*Explode explode = GameObject.FindGameObjectWithTag("Explode").GetComponent<Explode>();
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(ob.transform.position), out hit))
        {
            Instantiate(explode, hit.point, Quaternion.identity);
        }*/
    }
    /*private void ChangeObjColor(GameObject ob)
        {
            var objectRd = ob.GetComponent<Renderer>();
            Debug.Log(" ----->>>>   @ ChangeColor()  renderer: " + objectRd.material);
            objectRd.material.SetColor("_Color", Color.red);
            //gameObject.GetComponent<Renderer>().material.color  = UnityEngine.Random.ColorHSV(0.002f, 0.2f);
            

            
        }*/

}
