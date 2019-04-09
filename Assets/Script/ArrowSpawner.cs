using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public AnimationClip clipTimer;

    public Vector2[] spawnLocations;
    public GameObject[] Arrows;
    //index 0 = left || 1 = down || 2 = up || 3 = right
   

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomLoc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRandomLoc()
    {
        int randomIdex = Random.Range(0, spawnLocations.Length);

        Instantiate(Arrows[0], spawnLocations[randomIdex], transform.rotation);


        //Debug.Log("Spawned arrow!");
        //Debug.Log(randomIdex);
    }

    public void SpawnRight()
    {
        Instantiate(Arrows[0], spawnLocations[3], transform.rotation);
    }
}
