using System.Collections.Generic;
using UnityEngine;

[System.Serializable]             
public class ClassInfo
{
    public List<Sprite> Spade = new List<Sprite>();
    public List<Sprite> Diamond = new List<Sprite>();
    public List<Sprite> Hearts = new List<Sprite>();
    public List<Sprite> Clubs = new List<Sprite>();
}

[CreateAssetMenu(fileName = "CardFrontSprite", menuName = "Scriptable Objects/CardFrontSprite")]
public class CardFrontSprite : ScriptableObject
{
    public List<ClassInfo> FrontSprites = new List<ClassInfo>();
}
