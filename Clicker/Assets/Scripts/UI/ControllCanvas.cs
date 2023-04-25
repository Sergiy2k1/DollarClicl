using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllCanvas : MonoBehaviour
{
    [SerializeField] private Button _closeButton;

    private void Start()
    {
        _closeButton.onClick.AddListener(CloseGame);
    }
    private void CloseGame()
    {
        Debug.Log("Close the game");
        Application.Quit();
    }

}
