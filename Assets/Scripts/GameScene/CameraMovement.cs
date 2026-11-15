using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject Player;
    float Camera_Z_position;
    float Camera_X_position;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }

    private void LateUpdate()
    {
        Camera_Z_position = Player.transform.position.z;
        Camera_X_position = Player.transform.position.x - 1;
        transform.position = new Vector3(Camera_X_position, transform.position.y, Camera_Z_position);
    }
}
