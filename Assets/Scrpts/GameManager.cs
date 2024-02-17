using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    private int _playerScore;
    private int _computerScore;
    private string _winner;
    public Ball ball;
    //public GameManager gamemanager;
    public TMPro.TMP_Text general_text;
    public TMPro.TMP_Text player_score_text;
    public TMPro.TMP_Text computer_score_text;


    public void PlayerScores()
    {
        _playerScore++;
        this.ball.ResetPosition();
        Debug.Log("Player Scored");
        debugScores();
        //general_text.text = ("Player: " + _playerScore + "   Computer: " + _computerScore);
        player_score_text.text = (_playerScore.ToString());
        CheckForWinner();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.ball.ResetPosition();
        Debug.Log("Computer Scored");
        debugScores();
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
        if (_playerScore == 5 || _computerScore == 5)
            {
                if (_playerScore == 5)
                {
                    _winner = "The Player";
                } else
                {
                    _winner = "The Puter";
                }


            //this.ball.WaitForKeyToStart(true);
        }

            
    }

}
