using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public int combo;

    public Text ScoreTXT;
    public Text tempText;

    string qText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTXT.text = score.ToString();
        tempText.text = qText;
    }

    public void ShowQuality(string qualityText)
    {
        qText = qualityText;
        Debug.Log("a");
    }
}
