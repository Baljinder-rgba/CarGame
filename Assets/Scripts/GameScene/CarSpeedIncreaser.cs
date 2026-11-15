using UnityEngine;

public class CarSpeedIncreaser : MonoBehaviour
{
    [SerializeField] PlayerMovement Player;
    public bool canIncrease = false;
    private void FixedUpdate()
    {
        if (canIncrease)
        {
            IncreaseSpeed();
        }
    }

    void IncreaseSpeed()
    {
        Player.MovementSpeed = Mathf.Min(25, 10 + Time.time * 0.03f);
    }
}
