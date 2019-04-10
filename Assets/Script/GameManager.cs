using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score;
    public float combo;

    public Text ScoreTXT;
    public Text ComboText;

    public string qText;
    public Sprite[] qSprite;
    public GameObject qObject;

    SpriteRenderer qualityRenderer;
    Animator anim;

    public AudioSource song;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HelpMe", 1, 1);
        qualityRenderer = qObject.GetComponent<SpriteRenderer>();
        anim = qObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!song.isPlaying)
        {
            //go to end screen
            PlayerPrefs.SetFloat("Score", score);
            PlayerPrefs.SetFloat("Combo", combo);
            SceneManager.LoadSceneAsync("EndScreen");
        }

        ScoreTXT.text = score.ToString();
        ComboText.text = combo.ToString() + "X";

    }

    public void ShowQuality(int index)
    {
        qualityRenderer.sprite = qSprite[index];
        anim.Play("QualityText");
    }

    public void AddScore(int s)
    {
        score = score + s * (1 + combo / 10);
    }

}
