using UnityEngine;

public class CoinRotationScript : MonoBehaviour
{
    [SerializeField] float RotationSpeed = 5;
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
    }
}
