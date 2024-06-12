using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BattleUI : MonoBehaviour
{
    public Slider playerHPSlider;
    public Slider enemyHPSlider;
    public Pokemon_Player playerPokemon;
    public Pokemon_Ranghorang enemyPokemon;

    void Start()
    {
        playerHPSlider.maxValue = playerPokemon.maxHP;
        playerHPSlider.value = playerPokemon.currentHP;

        enemyHPSlider.maxValue = enemyPokemon.maxHP;
        enemyHPSlider.value = enemyPokemon.currentHP;
    }

    public void Update()
    {
        playerHPSlider.value = playerPokemon.currentHP;
        enemyHPSlider.value = enemyPokemon.currentHP;
    }
}
