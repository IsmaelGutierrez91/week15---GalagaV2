using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    int CurrentScore;
    public Text _TextComponent;
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void UpdateScore(int points)
    {
        CurrentScore = CurrentScore + points;
        _TextComponent.text = "POINTS: " + CurrentScore;
    }
}
