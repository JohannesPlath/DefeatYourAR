using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ArriveCannon : MonoBehaviour
{
     public GameOverScreen gameOverScreen;
     private int killedZombies = 0;
     
    public void OnCollisionEnter(Collision collision)
    {
       
        Debug.Log("------>>>>  @ CollisionDedection +collision.gameObject.tag: " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Zombie"))
        {
            Debug.Log("Zombie Arrived");
            GameOver();
        }
    }

    public void GameOver()
    {
        GameControlScript controlScript = GameObject.Find("XR Origin").GetComponent<GameControlScript>();
        controlScript.GameOver();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
