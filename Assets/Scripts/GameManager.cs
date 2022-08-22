using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SOGameData data;

    public void AddPoints(int points)
    {
        data.puntaje += points;
    }
}
