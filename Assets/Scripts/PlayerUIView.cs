using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUIView : MonoBehaviour
{
    [SerializeField] private Button _pauseBtn;
    [SerializeField] private TextMeshProUGUI _congratulationsTMP;
    private void Start()
    {
        _pauseBtn.onClick.AddListener(() => Pause());
        _congratulationsTMP.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        bool result = true;
        for(int i = 0; i< GameManager.UnlockedLevels.Count; i++)
        {
            if(result != GameManager.UnlockedLevels[i])
                result = false;
        }
        if(result == true)
        {
            _congratulationsTMP.gameObject.SetActive(true);
        }
    }
    private void Pause()
    {
        SceneManager.LoadScene("MainMenu");
    } 
}
