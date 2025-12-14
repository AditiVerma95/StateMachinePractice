using System.Collections.Generic;
using UnityEngine;

public class CardsManager : MonoBehaviour
{
    public static CardsManager Instance;

    public List<CardData> globalCards = new();

    private void Awake()
    {
        Instance = this;
    }
}