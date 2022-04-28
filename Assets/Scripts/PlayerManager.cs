using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool isGameStarted;
    public GameObject startingText;
    public static int numberOfCoins;
    public Text coinsText;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1; 
        isGameStarted = false;
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) // time is 0 when game is over and game over panel will appear
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        if(Input.anyKey) // input any key and the game will start and destroy the starting text
        {
            isGameStarted = true;
            Destroy(startingText);
        }
        coinsText.text = "Coins: "+numberOfCoins;
    }
}
