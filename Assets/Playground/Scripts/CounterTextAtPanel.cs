using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CounterTextAtPanel : MonoBehaviour
{

    public TMP_Text counterText;
    private string killedText = "Killed Zombies: ";
    private int counter = 0;
    private int spownedZombies = 0;
  
    /*void Start()
    {
        counterText.text = killedText + counter;
    }*/

   
    void Update()
    {
        counterText.text = killedText + counter;
    }

    public void SetText(int count)
    {   
        //Debug.Log("@CounterTextAtPlane Set Counter + count:  " + count);
        counter = count;
    }

    public void RespornedZombies(int spowned)
    {
        spownedZombies = spowned;
    }

    public int GetSpownedZombies()
    {
        return spownedZombies;
    }
}
