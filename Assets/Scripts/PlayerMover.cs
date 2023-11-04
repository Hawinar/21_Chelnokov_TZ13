using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2d;

    public float turnSpeed = 45;
    public float moveSpeed = 5;
    private void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - _rigidbody2d.transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        Vector3 targetRotation = new Vector3(0, 0, angle);
        _rigidbody2d.MoveRotation(Quaternion.RotateTowards(_rigidbody2d.transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime));
        _rigidbody2d.MovePosition(_rigidbody2d.position + ((Vector2)_rigidbody2d.transform.right * moveSpeed * Time.deltaTime));
        Time.timeScale = (float)(1f / 3f);
    }
    private void LateUpdate()
    {
        Time.timeScale = 1f;
    }
}
