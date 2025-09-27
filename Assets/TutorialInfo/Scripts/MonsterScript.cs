using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    [SerializeField]
    public int level = 1;
    [SerializeField]
    public int hp = 100;
    [SerializeField]
    public int damage = 10;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
