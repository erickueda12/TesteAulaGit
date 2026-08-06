using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "EnemySO")]
public class Enemy : ScriptableObject
{
    public int vida;
    public string nome;
    public float altura;
}
