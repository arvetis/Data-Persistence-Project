using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void StartGame()
    {
        if (GameData.PlayerName != null)
        {
            SceneManager.LoadScene(1);
        }

    }

    public void OnNameInputChanged(string newName)
    {
        GameData.PlayerName = newName;
    }
}
