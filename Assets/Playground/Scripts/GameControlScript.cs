using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    
    private CounterTextAtPanel counterScript;
    private AliveTextAtPanal aliveScript;

    public void GameOver()
    {
        GameOverScreen.Setup(askResults());
    }
    
    
    private int askResults(){
        counterScript = GameObject.Find("TMP_CounterDisplay").GetComponent<CounterTextAtPanel>();
        int spownedZombies = counterScript.GetSpownedZombies();
        aliveScript = GameObject.Find("TMP_Alivedisplay").GetComponent<AliveTextAtPanal>();
        int killeZombies = aliveScript.GetDestrtoyedZombies();
        return (spownedZombies - killeZombies);
    }
}
