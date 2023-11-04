using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlController : MonoBehaviour
{
    [SerializeField] private int nextLvlId;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.UnlockedLevels[nextLvlId] = true;
            Debug.Log($"Уровень {nextLvlId} открыт");
        }
    }
}
