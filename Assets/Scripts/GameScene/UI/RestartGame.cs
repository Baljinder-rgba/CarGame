using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartGameFunc()
    {
        SceneManager.LoadScene("GameScene");
    }
}
