using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StateManager.GameOver();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.useGravity = false;
        }
    }
}
