﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    //public AnimationClip clipTimer;

    public Vector2[] spawnLocations;
    public GameObject[] Arrows;
    public GameObject[] holdArrow;

    //index 0 = left || 1 = down || 2 = up || 3 = right
   

    // Start is called before the first frame update
    void Start()
    {
        //SpawnHold();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRandomLoc()
    {
        int randomIdex = Random.Range(0, spawnLocations.Length);

        Instantiate(Arrows[randomIdex], spawnLocations[randomIdex], transform.rotation);


        //Debug.Log("Spawned arrow!");
        //Debug.Log(randomIdex);
    }

    public void spawnLoc(int i)
    {
        Instantiate(Arrows[i], spawnLocations[i], transform.rotation);
    }

    public void SpawnHold()
    {
        int randomIndex = Random.Range(0, spawnLocations.Length);
        GameObject hArrow = Instantiate(holdArrow[randomIndex], spawnLocations[randomIndex], transform.rotation);
        StartCoroutine(hArrow.GetComponent<ArrowHold>().LongArrow(randomIndex, holdArrow[randomIndex], spawnLocations[randomIndex]));
        
    }

    public void timer()
    {
        Debug.Log(Time.time);
    }
}
