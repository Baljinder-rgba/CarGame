using System;
using TMPro;
using UnityEngine;

public class CoinScoreIncreaser : MonoBehaviour
{
    TextMeshProUGUI CoinScore;

    private void Awake()
    {
        CoinScore = GameObject.Find("CoinScore").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            int Coinscore = Convert.ToInt32(CoinScore.text);
            Coinscore = Coinscore + 1;
            CoinScore.text = Convert.ToString(Coinscore);
        }
    }
}
