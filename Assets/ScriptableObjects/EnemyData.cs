using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{
    [SerializeField]
    private Sprite _sprite;

    [SerializeField]
    private int _maxHealth;
    [SerializeField]
    private int _damage;
    [SerializeField]
    private float _moveSpeed;

    public Sprite Sprite => _sprite;
    public int MaxHealth => _maxHealth;
    public int Damage => _damage;
    public float MoveSpeed => _moveSpeed;
}
