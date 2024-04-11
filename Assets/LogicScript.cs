using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    private bool isScoringDisabled = false;
    public AudioSource dingSFX;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        if (!isScoringDisabled)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            dingSFX.Play();
        }
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
        isScoringDisabled = true;
    }
}
