using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public GameObject _mainMenu;
    public GameObject _credits;

    private void Start()
    {
        ShowMainMenu();
    }

    public void StartGame()
    {
        Application.LoadLevel(1);
    }

    public void ShowMainMenu()
    {
        _mainMenu.SetActive(true);
        _credits.SetActive(false);
    }

	public void ShowCredits()
    {
        _mainMenu.SetActive(false);
        _credits.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
