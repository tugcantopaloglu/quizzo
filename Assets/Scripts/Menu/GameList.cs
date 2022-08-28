using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameList : MonoBehaviour
{
    [Tooltip("To add some games to quizzo. Add it to the list below.")]
    [SerializeField] string[] gameNameList;

    public string GetGameList(int index)
    {
        return gameNameList[index];
    }
}
