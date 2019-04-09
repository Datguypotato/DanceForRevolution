using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButton : MonoBehaviour
{
    public KeyCode arrowButton;

    bool onTarget = false;
    GameManager gm;
    GameObject target;

    // Start is called before the first frame update
    void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(arrowButton))
        {
            if (onTarget)
            {
                float distance = Vector3.Distance(transform.position, target.transform.position);
                //Debug.Log(distance);
                QualityTiming(distance);

                Destroy(this.target);
                onTarget = false;
            }
            else
            {
                Debug.Log("You missed");
            }
        }
    }

    void QualityTiming(float dist)
    {
        

        if(dist > 0.75f)
        {
            gm.ShowQuality("absolute garbage");
            Debug.Log("absolute garbage");
        }
        else if(dist < 0.75 && dist > 0.4)
        {
            gm.ShowQuality("Nice");
            Debug.Log("nice");
            gm.score += 50;
            gm.combo++;
        }
        else
        {
            Debug.Log("Fucking noice");
            gm.score += 100;
            gm.combo++;
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            target = other.gameObject;
            onTarget = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            onTarget = false;
        }
    }
}
