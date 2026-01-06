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

    private void SpawnSuit(Suit suit, List<Sprite> frontSpriteList, Sprite backSprite)
    {
        for (int i = 0; i < 13; i++)
        {
            int rankIndex = i;

            // Spawn the card
            GameObject spawnedCard = Instantiate(cardPrefab, cardParent.transform);
            spawnedCard.name = suit + "_" + (Rank)rankIndex;

            // Get card data
            CardData spawnedCardData = spawnedCard.GetComponent<CardData>();

            // Set card rank
            spawnedCardData.rank = (Rank)rankIndex;

            // Set card suit
            spawnedCardData.suit = suit;

            // Set front sprite
            spawnedCardData.frontSprite = frontSpriteList[rankIndex];

            // Set back sprite
            spawnedCardData.backSprite = backSprite;

            // Add card to global list
            CardsManager.Instance.globalCards.Add(spawnedCardData);
        }
    }
}
