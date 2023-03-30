using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ArriveCannon : MonoBehaviour
{
     public GameOverScreen gameOverScreen;
     private int killedZombies = 0;
    void OnCollisionEnter(Collision collision)
    {
        //GameObject bullet = GameObject.Find("Bullet");
        Debug.Log("------>>>>  @ CollisionDedection +collision.gameObject.tag: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Cannon")
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverScreen.Setup(killedZombies);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
