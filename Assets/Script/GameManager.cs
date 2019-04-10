using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public int combo;

    public Text ScoreTXT;
    public Text ComboText;

    public string qText;
    public Sprite[] qSprite;
    public GameObject qObject;

    SpriteRenderer qualityRenderer;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        qualityRenderer = qObject.GetComponent<SpriteRenderer>();
        anim = qObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        ScoreTXT.text = score.ToString();
        ComboText.text = combo.ToString() + "X";

    }

    public void ShowQuality(int index)
    {
        qualityRenderer.sprite = qSprite[index];
        anim.Play("QualityText");
    }
}
