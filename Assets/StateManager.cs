using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class StateManager : MonoBehaviour
{
    public static StateManager instance;

    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject ScorePanel;

    [SerializeField] TextMeshProUGUI Score;
    [SerializeField] TextMeshProUGUI TracksCovered;

    [SerializeField] PlayerMovement Player;
    [SerializeField] CarSpeedIncreaser SpeedIncreaserScript;

    private void Awake()
    {
        instance = this;
    }
    public enum State
    {
        Playing,
        GameOver
    }

    public static void GameOver()
    {
        instance.Player.MovementSpeed = 0;
        instance.SpeedIncreaserScript.canIncrease = false;

        instance.Score.text = instance.TracksCovered.text;

        instance.GameOverPanel.SetActive(true);
        instance.ScorePanel.SetActive(false);
    }
}
