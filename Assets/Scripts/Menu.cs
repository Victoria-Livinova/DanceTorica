using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using System.Linq;

public class Menu : MonoBehaviour
{
    public GameObject[] navigationButtons;
    
    int currentButton;

    private void Start()
    {
        currentButton = 0;
    }
    public void OnPlayButton()
    {
        SceneManager.LoadScene(3);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }

    public void OnDownButton()
    {
        navigationButtons[(currentButton + 1) % navigationButtons.Length].GetComponent<UnityEngine.UI.Button>().Select();
        currentButton++;
    }

    public void OnAcceptButton()
    {
        navigationButtons[currentButton% navigationButtons.Length].GetComponent<UnityEngine.UI.Button>().onClick.Invoke();
    }
}
