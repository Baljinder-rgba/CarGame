using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStoMainM : MonoBehaviour
{
    public void ReturnToMainM()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
