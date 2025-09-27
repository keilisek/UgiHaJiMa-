using UnityEngine;

public class playerscript : MonoBehaviour
{
    [SerializeField]
    public int level = 1;
    [SerializeField]
    public int hp = 100;
    [SerializeField]
    public int damage = 10;

    [SerializeField]
    MonsterScript enemy = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    float sumTime = 0;

    // Update is called once per frame
    void Update()
    {
        sumTime += Time.deltaTime;
        if (sumTime >= 1)
        {
            if (enemy.hp > 0) {
                enemy.hp -= damage;
                if (enemy.hp <= 0)
                {
                    enemy.hp = 0;
                    Debug.Log("몬스터 죽었음");
                }

                Debug.Log($"몬스터의 체력은 {enemy.hp}입니다!");
                
            }
            sumTime = 0;
        }
    }
}
