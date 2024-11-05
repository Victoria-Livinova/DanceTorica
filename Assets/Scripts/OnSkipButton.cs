using UnityEngine;
using UnityEngine.SceneManagement;

public class OnSkipButton : MonoBehaviour
{
    public void OnSkipButtonn()
    {
        SceneManager.LoadScene(1);
    }
}
