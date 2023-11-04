using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2d;
    [SerializeField] private Camera _camera;

    [SerializeField] private GameObject _gameOverUI;
    [SerializeField] private Button _restartBtn;

    private void Start()
    {
        _rigidbody2d.position = (GameManager.PlayerPos);
        _camera.transform.position = GameManager.CameraPos;

        _gameOverUI.SetActive(false);
        _restartBtn.onClick.AddListener(()=> Restart());
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Spikes")
        {
            Debug.Log("Ты проиграл");
            _gameOverUI.SetActive(true);
        }
    }
    private void Restart()
    {
        _rigidbody2d.position = (GameManager.PlayerPos);
        _camera.transform.position = GameManager.CameraPos;

        SceneManager.LoadScene("Game");
    }

}
