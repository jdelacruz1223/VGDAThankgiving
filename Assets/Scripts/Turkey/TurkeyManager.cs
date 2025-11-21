using UnityEngine;
using UnityEngine.UIElements;

public class TurkeyManager : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] Vector3 positiveCornerOfArea;
    [SerializeField] Vector3 negativeCornerOfArea;

    [Header("References")]
    [SerializeField] BoxCollider boxCollider;
    [SerializeField] GameObject turkeyPrefab;

    void SpawnTurkey()
    {
        // e
    }

    void Update()
    {
        // figure out positive corner of box collider (+x, +y, and +z)
        positiveCornerOfArea = boxCollider.center;

        positiveCornerOfArea.x += (boxCollider.size.x / 2);
        positiveCornerOfArea.y += (boxCollider.size.y / 2);
        positiveCornerOfArea.z += (boxCollider.size.z / 2);

        // figure out negative corner
        negativeCornerOfArea = boxCollider.center;

        negativeCornerOfArea.x -= (boxCollider.size.x / 2);
        negativeCornerOfArea.y -= (boxCollider.size.y / 2);
        negativeCornerOfArea.z -= (boxCollider.size.z / 2);
    }
}
