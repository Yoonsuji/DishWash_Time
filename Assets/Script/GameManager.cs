using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BattleSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public BattleSystem battleSystem;
    public BattleUI battleUI;

    public Attack tackleAttack;
    public Attack waterBalloonAttack;

    private bool playerTurn = true;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        battleUI.Update();
    }

    public void OnTackleButtonClicked()
    {
        if (playerTurn)
        {
            battleSystem.PerformAttack(0);
            playerTurn = false;
        }
    }

    public void OnWaterBalloonButtonClicked()
    {
        if (playerTurn)
        {
            battleSystem.PerformAttack(1);
            playerTurn = false;
        }
    }
    public void OnEnemyAttackClicked()
    {
        if (!playerTurn)
        {
            battleSystem.PerformEnemyAttackAfterDelay();
            playerTurn = true;
        }
    }

}
