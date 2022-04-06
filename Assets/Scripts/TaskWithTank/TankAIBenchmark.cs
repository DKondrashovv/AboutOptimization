using UnityEngine;

public class TankAIBenchmark : MonoBehaviour
{
    GameObject[] tanks;
    public int numberOfTanks;
    [SerializeField] private GameObject enemyTank;
    [SerializeField] private UpdateManager _updateManager;

    void Start()
    {
        tanks = new GameObject[numberOfTanks];
        for (int i = 0; i < numberOfTanks; i++)
        {
            tanks[i] = Instantiate(enemyTank);
            tanks[i].transform.position = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));
            var tickableForTank = tanks[i].GetComponent<AIEnemyTank>();
            _updateManager.AddTank(tickableForTank);
        }
    }
}