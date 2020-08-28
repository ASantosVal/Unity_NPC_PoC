using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void CloseGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
