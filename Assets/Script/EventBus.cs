using UnityEngine;

public static class EventBus
{
    public delegate void BattleInEvent();
    public static event BattleInEvent OnBattleIn;

    public delegate void BagOpenEvent();
    public static event BagOpenEvent OnBagOpen;

    public delegate void RunEvent();
    public static event RunEvent OnRun;

    public delegate void OtherPokemonEvent();
    public static event OtherPokemonEvent OnOtherPokemon;

    public static void TriggerBattleIn()
    {
        OnBattleIn?.Invoke();
    }

    public static void TriggerBagOpen()
    {
        OnBagOpen?.Invoke();
    }

    public static void TriggerRun()
    {
        OnRun?.Invoke();
    }

    public static void TriggerOtherPokemon()
    {
        OnOtherPokemon?.Invoke();
    }
}
