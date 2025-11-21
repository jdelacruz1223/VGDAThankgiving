using UnityEngine;
using UnityEngine.UIElements;

public class TurkeyManager : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float turkeySpawnInterval = 5;

    [Header("Statistics")]
    [SerializeField] Vector3 positiveCornerOfArea;
    [SerializeField] Vector3 negativeCornerOfArea;

    [Header("References")]
    [SerializeField] BoxCollider boxCollider;
    [SerializeField] Timer timer;
    [SerializeField] GameObject turkeyPrefab;

    void SpawnTurkeyAtRandomPosition()
    {
        // e
        float randX = Random.Range(negativeCornerOfArea.x, positiveCornerOfArea.x);
        float randY = Random.Range(negativeCornerOfArea.y,positiveCornerOfArea.y);
        float randZ = Random.Range(negativeCornerOfArea.z,positiveCornerOfArea.z);
        Instantiate(turkeyPrefab, new Vector3(randX,randY,randZ),Quaternion.identity);
    }

    void Start()
    {
        timer.SetTime(turkeySpawnInterval);
    }

    void Update()
    {
        GetAreaCorners();
        SpawnTurkeyRoutinely();
    }

    void GetAreaCorners()
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
    void SpawnTurkeyRoutinely()
    {
        float timeRemaining = timer.GetTime();

        // once the time remaining is basically zero...
        if (timeRemaining <= Mathf.Epsilon)
        {
            // ...let's spawn a turkey at a random position...
            SpawnTurkeyAtRandomPosition();

            // ...and then reset the timer.
            timer.SetTime(turkeySpawnInterval);
        }
    }
}
