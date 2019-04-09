using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButton : MonoBehaviour
{
    public KeyCode arrowButton;

    public Sprite defaultSprite;
    public Sprite pressedSprite;

    bool onTarget = false;
    SpriteRenderer spriteRend;
    GameManager gm;
    GameObject target;

    // Start is called before the first frame update
    void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        spriteRend = GetComponent<SpriteRenderer>();
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

        if (Input.GetKey(arrowButton))
        {
            spriteRend.sprite = pressedSprite;
        }
        else
        {
            spriteRend.sprite = defaultSprite;
        }
    }

    void QualityTiming(float dist)
    {
        if(dist > 0.75f)
        {
            gm.ShowQuality(0);
            Debug.Log("absolute garbage");
        }
        else if(dist < 0.75 && dist > 0.6)
        {
            gm.ShowQuality(1);
            Debug.Log("nice");
            gm.score += 10;
            gm.combo++;
        }
        else if(dist < 0.6 && dist > 0.4)
        {
            Debug.Log("Fucking noice");
            gm.ShowQuality(2);
            gm.score += 25;
            gm.combo++;

        }
        else if(dist < 0.2 && dist > 0.1)
        {
            gm.ShowQuality(3);
            gm.score += 100;
            gm.combo++;

        }
        else
        {
            gm.ShowQuality(4);
            gm.score += 200;
            gm.combo++;
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Arrow"))
        {
            target = other.gameObject;
            onTarget = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Arrow"))
        {
            onTarget = false;
        }
    }

}
