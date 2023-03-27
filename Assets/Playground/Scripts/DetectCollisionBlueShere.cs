
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DetectCollisionBlueShere : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
      //if (collision.gameObject.tag == "BlueSphere")
      {
         Debug.Log("collision.gameObject.tag == BlueSphere :" + collision.gameObject.tag);
         var obRenderer = gameObject.GetComponent<Renderer>();
         /* Debug.Log("renderer: " + obRenderer);
         obRenderer.material.SetColor("_Color", Color.red);*/
         gameObject.GetComponent<Renderer>().material.color  = UnityEngine.Random.ColorHSV(0.002f, 0.2f);
         //obRenderer.material.SetColor("_magenta", Color.magenta);
      }
      
      Debug.Log("collision.gameObject.tag <<<  NOT  >>> BlueSphere, instead: " + collision.gameObject.tag);
         
   }
}
