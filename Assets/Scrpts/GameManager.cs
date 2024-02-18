using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public int _playerScore;
    public int _computerScore;
    private string _winner;
    public Ball ball;
    public TMPro.TMP_Text general_text;
    public TMPro.TMP_Text player_score_text;
    public TMPro.TMP_Text computer_score_text;


    public void PlayerScores()
    {
        _playerScore++;
        this.ball.ResetPosition();
        Debug.Log("Player Scored");
        //debugScores();
        //general_text.text = ("Player: " + _playerScore + "   Computer: " + _computerScore);
        player_score_text.text = (_playerScore.ToString());
        CheckForWinner();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.ball.ResetPosition();
        Debug.Log("Computer Scored");
        //debugScores();
        //general_text.text = ("Player: " + _playerScore + "   Computer: " + _computerScore);
        computer_score_text.text = (_computerScore.ToString());
        CheckForWinner();
    }

    public void debugScores()
    {
        Debug.Log("Player: " + _playerScore + "   Computer: " + _computerScore);
    }

    public void CheckForWinner()
    {
        if (_playerScore == 3 || _computerScore == 3)
            {
                if (_playerScore == 3)
                {
                    _winner = "The Player";
                } else
                {
                    _winner = "The Puter";
                }
            Debug.Log("Winner Detected");

            PlayerPrefs.SetString("Last_Winner", _winner);
            PlayerPrefs.SetString("Last_Player_Score", _playerScore.ToString());
            PlayerPrefs.SetString("Last_Computer_Score", _computerScore.ToString());
            

           // Debug.Log("Player Score Var: " + _playerScore);
           // Debug.Log("CPU Score Var: " + _computerScore);
           // Debug.Log("Player Prefs Score: " + PlayerPrefs.GetString("Last_Player_Score"));
           // Debug.Log("Computer Score Pref: " + PlayerPrefs.GetString("Last_Computer_Score"));
            
            SceneManager.LoadScene("Game Over");

            //this.ball.WaitForKeyToStart(true);
        }

            
    }

    void OnDisable()
    {
        //PlayerPrefs.SetInt("Last_Player_Score", _playerScore);
        //PlayerPrefs.SetInt("Last_Computer_Score", _computerScore);
    }

}
