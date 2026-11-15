using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class CountDownAtStart : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CountDownUI;
    [SerializeField] PlayerMovement Player;
    [SerializeField] CarSpeedIncreaser SpeedIncreaserScript;
    private void Start()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        for (int i = 3; i >= 0; i--)
        {
            //Debug.Log(i);
            if (i == 0)
            {
                CountDownUI.text = "GO";
                yield return new WaitForSeconds(1);
            }
            else
            {
                CountDownUI.text = Convert.ToString(i);
                yield return new WaitForSeconds(1);
            }
        }
        // Car Start
        CountDownUI.enabled = false;
        Player.MovementSpeed = 10;
        SpeedIncreaserScript.canIncrease = true;
    }

}
