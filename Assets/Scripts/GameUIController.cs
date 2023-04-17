using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameUIController : MonoBehaviour
{
    public Button menuButton;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        menuButton = root.Q<Button>("menu-button");

        menuButton.clicked += MenuButtonPressed;
    }

    void MenuButtonPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }

}

