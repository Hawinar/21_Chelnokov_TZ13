using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{

    [SerializeField] private GameObject _lvlSelectionUI;
    [SerializeField] private Button _playBtn;
    void Start()
    {
        _lvlSelectionUI.SetActive(false);
        _playBtn.onClick.AddListener(() => Play());
    }
    private void Play()
    {
        _lvlSelectionUI.SetActive(true);
        _playBtn.gameObject.SetActive(false);
    }
}
