using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public float test;

    Text t;
    public float score;
    float combo;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += 0.025f* Time.deltaTime;

        //Debug.Log(time);
        if(time > 0.9)
        {
            score = Mathf.Lerp(score, PlayerPrefs.GetInt("Score"), time);
            combo = Mathf.Lerp(combo, PlayerPrefs.GetInt("Combo"), time);
        }
        else
        {
            score = PlayerPrefs.GetInt("Score");
            combo = PlayerPrefs.GetInt("Combo");
        }

        
        t.text = "Score: " + Mathf.RoundToInt(score) + "\nHighest Combo: " + Mathf.RoundToInt(combo);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
