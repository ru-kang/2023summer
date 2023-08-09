using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //SceneManager


public class Score : MonoBehaviour
{
    Text scoreText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<Text>();
        scoreText.text = "0";
    }

    void Update(){
        if(score<0) SceneManager.LoadScene(2);
    }

    public void addScore()
    {
        score += 1;
        setScoreText();
    }

    public void subScore()
    {
        score -= 1;
        setScoreText();
    }

    public void setScoreText(){
        scoreText.text = score.ToString();
    }
}
