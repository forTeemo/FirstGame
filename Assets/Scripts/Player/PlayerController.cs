using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Move Settings")]
    [SerializeField]
    private float moveSpeed = 5.0f;

    private Rigidbody2D _rigidbody2D;
    private InputAction _moveAction;
    private Vector2 _moveDirection;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 0;
        _rigidbody2D.freezeRotation = true;

        _moveAction = InputSystem.actions.FindAction("Move");
    }
    private void Update()
    {
        _moveDirection = _moveAction.ReadValue<Vector2>().normalized;
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + moveSpeed * Time.deltaTime * _moveDirection);
    }
}
