using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] Enemy enemy1;

    void Start()
    {
        print(enemy1.vida);
        print(enemy1.nome);
        print(enemy1.altura);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
