using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    [SerializeField] private Goal goal;
    [SerializeField] private Coins coins;
    [SerializeField] private TextMeshProUGUI scoreNumberText;
    [SerializeField] private TextMeshProUGUI loseText;
    [SerializeField] private TextMeshProUGUI restartText;
    [SerializeField] private TextMeshProUGUI winText;
    private bool restartState;
    
    public int score;

    private void Awake()
    {
        Time.timeScale = 1.0f;
        restartState = false;
        score = 0;
        loseText.enabled = false;
        restartText.enabled = false;
        winText.enabled = false;
    }

    private void Update()
    {
        if (restartState)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                SceneManager.LoadScene(0);
        }
    }

    public void GameOver()
    {
        loseText.enabled = true;
        restartText.enabled = true;
        Time.timeScale = 0f;
        restartState = true;
    }

    public void AddScore()
    {
        score++;
        scoreNumberText.text = score.ToString();
    }

    public void GameWin()
    {
        winText.enabled = true;
        restartText.enabled = true;
        Time.timeScale = 0f;
        restartState = true;
    }
}
