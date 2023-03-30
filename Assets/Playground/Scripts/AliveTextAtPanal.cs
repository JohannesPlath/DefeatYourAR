using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AliveTextAtPanal : MonoBehaviour
{
    
    private int _spownedZombies = 0;
    private int _destroyedZombies = 0;
    private string _aliveText = "Living Zombies: ";
    public TMP_Text livingText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int zombiesAlive = _spownedZombies - _destroyedZombies;
        livingText.text = _aliveText + zombiesAlive;
    }
    
    public void RespZombies(int spown)
    {
        _spownedZombies = spown;
    }

    public void DestrtoyedZombies(int count)
    {
        _destroyedZombies = count;
    }
    public int GetDestrtoyedZombies()
    {
        return _destroyedZombies;
    }
}
