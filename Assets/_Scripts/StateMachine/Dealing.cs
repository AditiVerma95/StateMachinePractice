using System.Collections.Generic;
using UnityEngine;

public class Dealing : MonoBehaviour
{
    [SerializeField] private RectTransform left;
    [SerializeField] private RectTransform right;

    private List<CardData> globalCards;

    public void StartDealing()
    {
        globalCards = CardsManager.Instance.globalCards;

        Vector2 leftPos =
            UniversalPositionsOfObjects.Instance.GetPositionFromCanvasCenter(left);
        Vector2 rightPos =
            UniversalPositionsOfObjects.Instance.GetPositionFromCanvasCenter(right);

        float distance = Vector2.Distance(leftPos, rightPos);
        float offset = distance / 12f;

        for (int i = 0; i < 13; i++)
        {
            CardData card = globalCards[i];
            RectTransform cardRect = card.GetComponent<RectTransform>();

            Vector2 targetPos = leftPos;
            targetPos.x += offset * i;

            cardRect.anchoredPosition = targetPos;
        }
    }

    public void EndDealing()
    {
    }
}
