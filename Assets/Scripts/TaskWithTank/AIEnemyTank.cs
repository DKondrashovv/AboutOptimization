using UnityEngine;

public class AIEnemyTank : MonoBehaviour, ITickable
{
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    public void Tik()
    {
        var playerPos = player.transform.position;
        transform.LookAt(playerPos);
        transform.Translate(0, 0, 0.05f);
    }
}