using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSpawner : MonoBehaviour
{
    public bool canSpawn = true;

    public GameObject sharkPrefab;
    public List<Transform> sharkSpawnPositions = new List<Transform>();
    public float timeBetweenSpawns;

    private List<GameObject> SharkList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (canSpawn)
        {
            SpawnShark();
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }

    private void SpawnShark()
    {
        Vector3 randomPosition = sharkSpawnPositions[Random.Range(0, sharkSpawnPositions.Count)].position;
        GameObject shark = Instantiate(sharkPrefab, randomPosition, sharkPrefab.transform.rotation);
        SharkList.Add(shark);
        shark.GetComponent<Shark>().SetSpawner(this);
    }

    public void RemoveSharkFromList(GameObject shark)
    {
        SharkList.Remove(shark);
    }

    public void DestroyAllShark()
    {
        foreach (GameObject shark in SharkList)
        {
            Destroy(shark);
        }

        SharkList.Clear();
    }
}