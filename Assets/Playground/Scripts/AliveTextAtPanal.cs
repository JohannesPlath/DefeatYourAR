using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AliveTextAtPanal : MonoBehaviour
{
    
    private int spownedZombies = 0;
    private int destreyedZombies = 0;
    private string aliveText = "Liv´n Zombies: ";
    public TMP_Text livingText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int zombiesAlive = spownedZombies - destreyedZombies;
        livingText.text = aliveText + zombiesAlive;
    }
    
    public void RespZombies(int spown)
    {
        spownedZombies = spown;
    }

    public void DestrtoyedZombies(int count)
    {
        destreyedZombies = count;
    }
}
