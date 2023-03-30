using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class CollisionDedection : MonoBehaviour
{
    private GameObject objectToDelete;
    private GameObject bullet;
    private static int counter = 0;
    public GameObject exp;
    public CounterAtPanel display;
    
    void OnCollisionEnter(Collision collision)
    {
        bullet = GameObject.Find("Bullet");
       // Debug.Log("------>>>>  @ CollisionDedection +collision.gameObject.tag: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Zombie")
        {
            objectToDelete = GameObject.Find(collision.gameObject.name);
            counter += 1;
            TryToDestroy(objectToDelete);
            TryToDestroy(bullet);
            Explosion(bullet);
            SetDisplay();
        }
        else if (collision.gameObject.tag == "Trees")
        {   
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
        Destroy(_exp, 0.5f);
        Destroy(ob);
    }

    public void SetDisplay()
    {
        display = GameObject.Find("TMP_CounterDisplay").GetComponent<CounterAtPanel>();
        display.SetText(counter);
    }
    
}
