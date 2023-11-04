using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static List<bool> UnlockedLevels = new List<bool>() { true, false, false, false, false };
    public static Vector3 CameraPos;
    public static Vector3 PlayerPos;
}
