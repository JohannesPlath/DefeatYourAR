using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;
using UnityEngine.Serialization;

public class CollisionDedection : MonoBehaviour
{
    private GameObject objectToDelete;
    private GameObject bullet;
    private static int counter = 0;
    public GameObject exp;
    private CounterTextAtPanel counterScript;
    private AliveTextAtPanal aliveScript;
    [SerializeField] private GameObject cannon;
    
    void OnCollisionEnter(Collision collision)
    {
        bullet = GameObject.Find("Bullet");
       // Debug.Log("------>>>>  @ CollisionDedection +collision.gameObject.tag: " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Zombie"))
        {
            objectToDelete = GameObject.Find(collision.gameObject.name);
            counter += 1;
            TryToDestroy(objectToDelete);
            TryToDestroy(bullet);
            Explosion(bullet);
            SetDisplay();
        }
        else if (collision.gameObject.tag is "Trees" or "Grave")
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
        cannon = GameObject.FindGameObjectWithTag("CannonMain");
        Debug.Log("found CannonMain: " + cannon);
        GameObject _exp = Instantiate(this.exp, transform.position, transform.rotation);
        Destroy(_exp, 0.2f);
        Destroy(ob);
        Destroy(cannon);
    }

    public void SetDisplay()
    {
        counterScript = GameObject.Find("TMP_CounterDisplay").GetComponent<CounterTextAtPanel>();
        counterScript.SetText(counter);
        aliveScript = GameObject.Find("TMP_Alivedisplay").GetComponent<AliveTextAtPanal>();
        aliveScript.DestrtoyedZombies(counter);
    }
    
}
