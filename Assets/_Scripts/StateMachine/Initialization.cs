using System.Collections.Generic;
using UnityEngine;

public class Initialization : MonoBehaviour
{
    [SerializeField] private Transform cardParent;
    [SerializeField] private GameObject cardPrefab;

    [SerializeField] private CardBackSprite backSpritesDb;
    [SerializeField] private CardFrontSprite frontSpritesDb;



    private void Start()
    {

    }

    public void StartInitialization()
    {
        SpawnSuit(Suit.Spade, frontSpritesDb.FrontSprites[0].Spade, backSpritesDb.BackSprites[0]);
        SpawnSuit(Suit.Diamond, frontSpritesDb.FrontSprites[0].Diamond, backSpritesDb.BackSprites[0]);
        SpawnSuit(Suit.Heart, frontSpritesDb.FrontSprites[0].Hearts, backSpritesDb.BackSprites[0]);
        SpawnSuit(Suit.Clubs, frontSpritesDb.FrontSprites[0].Clubs, backSpritesDb.BackSprites[0]);
        EndInitialization();
    }
    public void EndInitialization()
    {
        StateManager.Instance.ChangeState(GameState.Dealing);
    }

    private void SpawnSuit(Suit suit,List<Sprite> frontSpriteList,Sprite backSprite)
    {
        for (int i = 0; i < 13; i++)
        {
            Rank rank = (Rank)i;

            GameObject spawnedCard = Instantiate(cardPrefab, cardParent);

            spawnedCard.name = $"{suit}_{rank}";

            CardData cardData = spawnedCard.GetComponent<CardData>();

            cardData.rank = rank;
            cardData.suit = suit;
            cardData.frontSprite = frontSpriteList[i];
            cardData.backSprite = backSprite;

            CardsManager.Instance.globalCards.Add(cardData);
        }
    }

}
