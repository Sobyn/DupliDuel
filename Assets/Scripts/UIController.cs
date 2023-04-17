using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("start-button");
        quitButton = root.Q<Button>("quit-button");

        startButton.clicked += StartButtonPressed;
        quitButton.clicked += QuitButtonPressed;
    }

    void StartButtonPressed()
    {
        SceneManager.LoadScene("Game");
    }

    void QuitButtonPressed()
    {
        Application.Quit();
        Debug.Log("Game Quit!");
    }

}
