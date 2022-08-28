using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject[] menuButtons;
    [SerializeField] GameList gameList;
    void Start()
    {
        SetMenuButtons();
    }
    void SetMenuButtons()
    {
        for (int i = 0; i < menuButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = menuButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = gameList.GetGameList(i);
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
