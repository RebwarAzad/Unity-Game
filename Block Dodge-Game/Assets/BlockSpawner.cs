using UnityEngine;


public class BlockSpawner : MonoBehaviour
{
    public Transform [] Spawner;
    public GameObject blockprefab;

     private float TimeDelay=1f;
     public float TimeToSpawn=2f;
    

    // Start is called before the first frame update
    void Update(){
        if (Time.time>=TimeToSpawn)
        {
             SpawnBlocks();
             TimeToSpawn=Time.time+TimeDelay;
        }
   
    }
    void SpawnBlocks(){
          int randomIndex=Random.Range(0,Spawner.Length);  

      for (int i = 0; i < Spawner.Length; i++)
      {
          if (randomIndex!=i)
          {
              Instantiate(blockprefab,Spawner[i].position,Quaternion.identity);
          }
      }
    }

    
}
