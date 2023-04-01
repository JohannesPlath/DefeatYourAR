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
        aliveScript = GameObject.Find("TMP_Alivedisplay").GetComponent<AliveTextAtPanal>();
        return aliveScript.GetDestrtoyedZombies();
    }
}
