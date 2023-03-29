using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CounterAtPanel : MonoBehaviour
{

    public TMP_Text counterText;
    private string text = "Killed Zombies: ";
    private int counter = 0;
    
  
    void Start()
    {
        counterText.text = text + counter;
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = text + counter;
    }

    public void SetText(int count)
    {   
        Debug.Log("@CounterTextAtPlane Set Counter + count:  " + count);
        counter = count;
    }
}
