using UnityEngine;

public class UniversalPositionsOfObjects : MonoBehaviour {
    public static UniversalPositionsOfObjects Instance;

    public RectTransform universalCenter;

    private void Awake() {
        Instance = this;
    }

    public Vector2 GetPositionFromCanvasCenter(RectTransform target) {
        // Convert target's world position into local space of canvas
        Vector3 localPos = universalCenter.InverseTransformPoint(target.position);

        return new Vector2(localPos.x, localPos.y);
    }
}