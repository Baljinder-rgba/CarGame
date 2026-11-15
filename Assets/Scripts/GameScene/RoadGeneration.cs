using UnityEngine;

public class RoadGeneration : MonoBehaviour
{
    public enum TrackType
    {
        Vertical,
        HorizontalRight,
        HorizontalLeft
    }

    [SerializeField] TrackType trackType;
    [SerializeField] GameObject Track_vert;
    [SerializeField] GameObject Track_hori_right;
    [SerializeField] GameObject Track_hori_left;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int RandomNumber = Random.Range(0,3);
            Vector3 instanciatePosition;

            if (RandomNumber == 0) // Instantiate Vertical Track
            {
                if (trackType == TrackType.Vertical) // This One is Vertical
                {
                    instanciatePosition = transform.position + new Vector3(0, 0, 15);
                    Instantiate(Track_vert, instanciatePosition, Quaternion.identity);
                }
                else if (trackType == TrackType.HorizontalRight) // This One is Horizontal Right
                {
                    instanciatePosition = transform.position + new Vector3(10, 0, 5);
                    Instantiate(Track_vert, instanciatePosition, Quaternion.identity);
                }
                else if (trackType == TrackType.HorizontalLeft) // This One is Horizontal Left
                {
                    instanciatePosition = transform.position + new Vector3(-10, 0, 5);
                    Instantiate(Track_vert, instanciatePosition, Quaternion.identity);
                }
            }


            else if (RandomNumber == 1) // Instanciate Horizontal Track Right
            {
                if (trackType == TrackType.HorizontalLeft)
                {
                    instanciatePosition = transform.position + new Vector3(-10, 0, 5);
                    Instantiate(Track_vert, instanciatePosition, Quaternion.identity);
                }
                else if (trackType == TrackType.Vertical)
                {
                    instanciatePosition = transform.position + new Vector3(5, 0, 10);
                    Instantiate(Track_hori_right, instanciatePosition, Quaternion.identity);
                }
                else if (trackType == TrackType.HorizontalRight)
                {
                    instanciatePosition = transform.position + new Vector3(15, 0, 0);
                    Instantiate(Track_hori_right, instanciatePosition, Quaternion.identity);
                }
            }


            else if (RandomNumber == 2) // Instanciate Horizontal Track Left
            {
                if (trackType == TrackType.HorizontalRight)
                {
                    instanciatePosition = transform.position + new Vector3(10, 0, 5);
                    Instantiate(Track_vert, instanciatePosition, Quaternion.identity);
                }
                else if (trackType == TrackType.Vertical)
                {
                    instanciatePosition = transform.position + new Vector3(-5, 0, 10);
                    Instantiate(Track_hori_left, instanciatePosition, Quaternion.identity);
                }
                else if (trackType == TrackType.HorizontalLeft)
                {
                    instanciatePosition = transform.position + new Vector3(-15, 0, 0);
                    Instantiate(Track_hori_left, instanciatePosition, Quaternion.identity);
                }
            }
        }
    }
}
