using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardBackSprite", menuName = "Scriptable Objects/CardBackSprite")]
public class CardBackSprite : ScriptableObject
{
    public List<Sprite> BackSprites = new();
}
