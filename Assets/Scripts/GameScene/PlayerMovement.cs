using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 0;
    Quaternion targetRotation;

    // --- Swipe variables (ADDED) ---
    Vector2 startTouchPosition;
    Vector2 endTouchPosition;
    float swipeThreshold = 50f;
    // --------------------------------

    private void Start()
    {
        targetRotation = transform.rotation;
    }

    private void Update()
    {
        MoveForward();
        RotateRight();
        RotateLeft();
        ContinuousRotation();
        SwipeControls(); // ADDED
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
    }

    void RotateRight()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            float y = Mathf.Round(transform.eulerAngles.y);

            if (y == 0f || y == 270f)
            {
                targetRotation *= Quaternion.Euler(0f, 90f, 0f);
            }
        }
    }

    void RotateLeft()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            float y = Mathf.Round(transform.eulerAngles.y);

            if (y == 0f || y == 90f)
            {
                targetRotation *= Quaternion.Euler(0f, -90f, 0f);
            }
        }
    }

    void ContinuousRotation()
    {
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            10f * Time.deltaTime
        );
    }

    // -------- Swipe Controls (ADDED) --------
    void SwipeControls()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position;
                float deltaX = endTouchPosition.x - startTouchPosition.x;

                float y = Mathf.Round(transform.eulerAngles.y);

                if (Mathf.Abs(deltaX) > swipeThreshold)
                {
                    // Swipe Right
                    if (deltaX > 0 && (y == 0f || y == 270f))
                    {
                        targetRotation *= Quaternion.Euler(0f, 90f, 0f);
                    }
                    // Swipe Left
                    else if (deltaX < 0 && (y == 0f || y == 90f))
                    {
                        targetRotation *= Quaternion.Euler(0f, -90f, 0f);
                    }
                }
            }
        }
    }
}
