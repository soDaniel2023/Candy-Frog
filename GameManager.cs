using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score = 0;

    public TextMeshProUGUI scoreText;

    public GameObject LivesPanel;

    public GameObject gameOverPanel;

    int lives = 3;
    bool gameOver = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {    
    }

    void Update()
    {
    }

    public void IncrementScore()
    {
        score ++;
        scoreText.text = score.ToString();
        print("Score is now: "+score);
    }

    public void DecrementLives()
    {
        print ("lives is now: " + lives);
        if (lives > 0)
        {
            lives--;
            LivesPanel.transform.GetChild(lives).gameObject.SetActive(false);
        }
        if (lives==0)
        {
            print ("lives is now: " + lives);
            gameOver = true;
            GameOver();
        }

    }

    void GameOver()
    {
        CandySpawner.instance.StopSpawningCandies();
        GameObject.Find("Player").GetComponent<Player>().canMove = false;
        gameOverPanel.SetActive(true);
        print ("lives is <0 calling gmae over: " + lives);
        print("Game Over!!!!");
    }
    public void Restart()
    {
        SceneManager.LoadScene("CandyGame");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
