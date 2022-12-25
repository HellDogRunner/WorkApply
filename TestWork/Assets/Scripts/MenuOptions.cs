using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{
    [SerializeField] private EnemyData Bomberdata;
    [SerializeField] private EnemyData Marinedata;
    [SerializeField] private EnemyData Shooterdata;
    
    [SerializeField] private PlayerData playerData;
    [SerializeField] private InputField PlayerHp;
    [SerializeField] private InputField PlayerDmg;
    
    [SerializeField] private InputField EnemyBomberHp;
    [SerializeField] private InputField EnemyBomberDmg;
    
    [SerializeField] private InputField EnemyMarineHp;
    [SerializeField] private InputField EnemyMarineDmg;
    
    [SerializeField] private InputField EnemyShooterHp;
    [SerializeField] private InputField EnemyShooterDmg;
    
    [SerializeField] private InputField EnemySpawnRate;


    public void ChangeValues()
    {
        Bomberdata.damage = int.Parse(EnemyBomberDmg.text);
        Bomberdata.hp = int.Parse(EnemyBomberHp.text);
        
        Marinedata.damage = int.Parse(EnemyMarineDmg.text);
        Marinedata.hp = int.Parse(EnemyMarineHp.text);
        
        Shooterdata.damage = int.Parse(EnemyShooterDmg.text);
        Shooterdata.hp = int.Parse(EnemyShooterHp.text);
        
        playerData.damage=int.Parse(PlayerDmg.text);
        playerData.hp=int.Parse(PlayerHp.text);
        
        Shooterdata.spawnInterval=int.Parse(EnemySpawnRate.text);
        
    }
}
