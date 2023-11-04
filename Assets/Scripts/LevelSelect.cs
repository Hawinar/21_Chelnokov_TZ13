using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] private Button _goLevelBtn;
    [SerializeField] private Vector3 _cameraPos;
    [SerializeField] private Vector3 _playerPos;
    [SerializeField] private int _lvlId;
    void Start()
    {
        if (GameManager.UnlockedLevels[_lvlId] == true)
        {
            _goLevelBtn.onClick.AddListener(() => GoLevel());
            _goLevelBtn.image.color = Color.green;
        }
        else
        {
            _goLevelBtn.image.color = Color.red;
        }
    }

    // Update is called once per frame
    private void GoLevel()
    {
        GameManager.CameraPos = _cameraPos;
        GameManager.PlayerPos = _playerPos;

        SceneManager.LoadScene("Game");
    }
}
