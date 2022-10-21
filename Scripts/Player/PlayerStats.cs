using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats : MonoBehaviour
{
    private float PlayerHPmax;
    [SerializeField] private float PlayerHP;

    public void setPlayerHPmax(float a)
    {
        PlayerHPmax = a;
        PlayerHP = PlayerHPmax;
    }
    public void updatePlayerHP(float a)
    {
        PlayerHP += a;
    }
    public float getPlayerHP()
    {
        return PlayerHP;
    }

    // Start is called before the first frame update
    void Start()
    {
        setPlayerHPmax(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
