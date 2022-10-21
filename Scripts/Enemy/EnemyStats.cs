using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyStats : MonoBehaviour
{
    private float EnemyHPmax;
    [SerializeField] private float EnemyHP;

    public void setEnemyHPmax(float a)
    {
        EnemyHPmax = a;
        EnemyHP = EnemyHPmax;
    }
    public void updateEnemyHP(float a)
    {
        EnemyHP += a;
    }
    public float getEnemyHP()
    {
        return EnemyHP;
    }

    // Start is called before the first frame update
    void Start()
    {
        setEnemyHPmax(10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
