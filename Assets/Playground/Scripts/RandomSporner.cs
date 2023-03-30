using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSporner : MonoBehaviour
{

    [SerializeField] private GameObject[] zombies;
    [SerializeField] private  int _spawnTime = 3;
    [SerializeField] private int _reepeatRate = 2;
    private Rigidbody rb;
    private Vector3 spawnPos;
    private int aliveZombies;
    private AliveTextAtPanal display;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Start()
    {
        spawnPos = rb.position;
        InvokeRepeating("SpawnZombie", _spawnTime, _reepeatRate);
    }

    void Update()
    {
        
    }

    private void SpawnZombie()
    {
        int randomIndex = Random.Range(0, zombies.Length);
        Instantiate(zombies[randomIndex], spawnPos, Quaternion.identity);
        aliveZombies += 1;
        SetAliveDisplay();
    }

    private void SetAliveDisplay()
    {
        display = GameObject.Find("TMP_Alivedisplay").GetComponent<AliveTextAtPanal>();
        display.RespZombies(aliveZombies); 
    }
}
