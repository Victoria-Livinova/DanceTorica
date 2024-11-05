using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    TextMeshPro text;
    public void OnHome()
    {
        SceneManager.LoadScene(0);
        ArrDropController.score = 0;
        
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(1);
        ArrDropController.score = 0;
    }
}
