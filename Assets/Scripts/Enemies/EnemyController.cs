using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private EnemyData _enemyData;
    [SerializeField]
    private Transform _player;

    private SpriteRenderer _spriteRenderer;
    private int _currentHealth;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.sprite = _enemyData.Sprite;
        _currentHealth = _enemyData.MaxHealth;
    }
    private void FixedUpdate()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, _player.position, _enemyData.MoveSpeed * Time.deltaTime);
    }
}
