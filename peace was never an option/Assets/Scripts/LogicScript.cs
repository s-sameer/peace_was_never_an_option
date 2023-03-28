using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    public Text coinText;
    public GameObject gameOverScreen;
    public float score = 0;
    public int coins = 0;


    public void increaseScore()
    {
        score = score + Time.deltaTime*3;
        scoreText.text = ((int)score).ToString();
    }

    public void increaseCoins()
    {
        coins = coins + 1;
        coinText.text = coins.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public int getCoins(){
        return coins;
    }

    //to move back to main screen
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Shop()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
