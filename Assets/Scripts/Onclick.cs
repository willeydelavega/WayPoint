using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onclick : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField]  List<Transform> transforms;
   public GameObject spawnPrefab;
    public Transform waypoint1;
     public Transform waypoint2;
     public Transform waypoint3;
 

    void Start()
    {
        transforms = new List<Transform>()
    {
        waypoint1,
        waypoint2,
        // ...
        waypoint3
    };
    }

    // Update is called once per frame
    void Update()
    {
    }
        private void OnMouseDown()
    {
      
       {
        StartCoroutine(WaitOneFrame());

        //  GameObject spawnedCube = Instantiate(spawnPrefab,waypoint1.position, Quaternion.identity);
       }
    }



 IEnumerator WaitOneFrame() {
    
     GameObject spawnedCube = Instantiate(spawnPrefab,waypoint1.position, Quaternion.identity);
   yield return new WaitForSeconds(2f);
   
    spawnedCube.transform.position = transforms[1].position;
    yield return new WaitForSeconds(2f);
    spawnedCube.transform.position = transforms[2].position;

    //  GameObject spawnedCube1 = Instantiate(spawnPrefab,waypoint2.position, Quaternion.identity);
    //  yield return new WaitForSeconds(2f);
    //  GameObject spawnedCube2 = Instantiate(spawnPrefab,waypoint3.position, Quaternion.identity);


}


}
