using UnityEngine;

public class RoadDestruction : MonoBehaviour
{
    float DistanceFromPlayer;
    GameObject Player;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }

    private void FixedUpdate()
    {
        DistanceFromPlayer = Vector3.Magnitude(Player.transform.position - transform.position);
        if (DistanceFromPlayer > 30)
        {
            Destroy(this.gameObject);
        }
    }
}
