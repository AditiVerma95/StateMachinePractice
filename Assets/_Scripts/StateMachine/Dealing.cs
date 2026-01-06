using UnityEngine;

public class Dealing : MonoBehaviour
{
    [SerializeField] private RectTransform left;
    [SerializeField] private RectTransform right;
    private void StartDealing()
    {
        Vector2 leftPos = UniversalPositionsOfObjects.Instance.GetPositionFromCanvasCenter(left);
        Vector2 rightPos = UniversalPositionsOfObjects.Instance.GetPositionFromCanvasCenter(right);
        float distance = Vector2.Distance(leftPos, rightPos);
        Debug.Log(distance);
        float offset = distance / 12;
        
    }
    private void EndDealing()
    {

    }

}
