using System;
using TMPro;
using UnityEngine;

public class TrackScoreCount : MonoBehaviour
{
    TextMeshProUGUI TracksCoveredScore;

    private void Awake()
    {
        TracksCoveredScore = GameObject.Find("TracksCovered").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int score = Convert.ToInt32(TracksCoveredScore.text);
            score = score + 1;
            TracksCoveredScore.text = Convert.ToString(score);
        }
    }
}
