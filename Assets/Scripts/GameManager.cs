using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerMovement movement;
    public followPlayer maincamera;
    public Score score;

    public GameObject scoreUI;
    public GameObject EndScoreUI;
    public GameObject HighScoreUI;
    public GameObject EndMenuUI;
    public GameObject JoystickUI;

    public bool isEnded = false;
    public bool isEndedGM = false;

    public Text endScoreNumber;
    public Text highScoreNumber;

    public void EndGame()
    {
        isEnded = true;
        movement.enabled = false;
        maincamera.enabled = false;
        score.enabled = false;
        scoreUI.SetActive(false);
        EndMenuUI.SetActive(true);
        JoystickUI.SetActive(false);
        HighScore();
        isEndedGM = true;
    }

    void HighScore()
    {
        if (!isEndedGM)
        {
            int cur_score = int.Parse(score.scoreText.text);
            int highscore = PlayerPrefs.GetInt("highscore", 0);

            Debug.Log("Skor:" + cur_score);
            Debug.Log("highscore:" + highscore);


            if (cur_score > highscore)
            {
                PlayerPrefs.SetInt("highscore", cur_score);
                highScoreNumber.text = cur_score.ToString("0");
                HighScoreUI.SetActive(true);
            }
            else
            {
                endScoreNumber.text = cur_score.ToString("0");
                EndScoreUI.SetActive(true);
            }
        }
    }

}
