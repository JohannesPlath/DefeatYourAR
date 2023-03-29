using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CounterAtPanel : MonoBehaviour
{

    public TMP_Text counterText;
    private string text = "Killed Zombies: ";
    // Start is called before the first frame update
    void Start()
    {
        counterText.text = text;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetText(int count)
    {
        text = text + count;
    }
}
