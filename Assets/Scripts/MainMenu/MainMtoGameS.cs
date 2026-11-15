using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMtoGameS : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
