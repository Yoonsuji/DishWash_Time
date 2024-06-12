using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSystem : MonoBehaviour
{
    public GameObject First_canvas;
    public GameObject Battle_Canvas;
    public GameObject Bag_Canvas;
    public GameObject OtherPokemon_Canvas;
    public GameObject SceneLoader;

    void Start()
    {
        EventBus.OnBattleIn += OnBattleIn;
        EventBus.OnBagOpen += OnBagOpen;
        EventBus.OnRun += OnRun;
        EventBus.OnOtherPokemon += OnOtherPokemon;
    }

    public void OnBattleIn()
    {
        First_canvas.SetActive(false);
        Battle_Canvas.SetActive(true);
    }

    public void OnBagOpen()
    {
        First_canvas.SetActive(false);
        Bag_Canvas.SetActive(true);
    }

    public void OnRun()
    {
        First_canvas.SetActive(false);
        SceneLoader.SetActive(true);
    }

    public void OnOtherPokemon()
    {
        First_canvas.SetActive(false);
        OtherPokemon_Canvas.SetActive(true);
    }

    void OnDestroy()
    {
        EventBus.OnBattleIn -= OnBattleIn;
        EventBus.OnBagOpen -= OnBagOpen;
        EventBus.OnRun -= OnRun;
        EventBus.OnOtherPokemon -= OnOtherPokemon;
    }
}
