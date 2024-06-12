using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    public Pokemon_Player playerPokemon;
    public Pokemon_Ranghorang enemyPokemon;
    public Attack[] playerAttacks;
    public Attack[] enemyAttacks;

    private bool playerCanAttack = true;
    private bool enemyAttacking = false;

    [System.Serializable]
    public class Attack
    {
        public string attackName;
        public int damage;
    }

    public void PerformAttack(int attackIndex)
    {
        if (!playerCanAttack || enemyAttacking)
        {
            Debug.Log("Player cannot attack now.");
            return;
        }

        int randomIndex = Random.Range(0, playerAttacks.Length);
        Attack selectedAttack = playerAttacks[randomIndex];
        enemyPokemon.currentHP -= selectedAttack.damage;
        if (enemyPokemon.currentHP < 0)
        {
            enemyPokemon.currentHP = 0;
        }

        StartCoroutine(PerformEnemyAttackAfterDelay());

    }
    public IEnumerator PerformEnemyAttackAfterDelay()
    {
        enemyAttacking = true;

        yield return new WaitForSeconds(1f);

        int randomIndex = Random.Range(0, enemyAttacks.Length);
        Attack selectedAttack = enemyAttacks[randomIndex];
        playerPokemon.currentHP -= selectedAttack.damage;
        if (playerPokemon.currentHP < 0)
        {
            playerPokemon.currentHP = 0;
        }

        enemyAttacking = false;
        playerCanAttack = true;
    }
}
