using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHold : Arrow
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("OOF", 2);
        Destroy(this.gameObject, 3);

    }

    // Update is called once per frame
    void Update()
    {
        GoDown();
        
    }

    public IEnumerator LongArrow(int randomIndex, GameObject arrow, Vector3 spawnLoc)
    {

        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(0.05f);
            GameObject go = Instantiate(arrow, spawnLoc, transform.rotation);
            go.GetComponent<SpriteRenderer>().sortingOrder = i;
        }
    }
}
