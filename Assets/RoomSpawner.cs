// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class RoomSpawner : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public Direction direction;
//     public enum Direction {
//         Top, 
//         Bottom,
//         Left,
//         Right,
//         None

//     }
//     private RoomVariants variants;
//     private int rand;
//     private bool spawned = false;
//     private float waitTime = 3f;
//     void Start()
//     {
//         variants = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomVariants>();
//         Destroy(gameObject, waitTime);
//         Invoke("Spawn", 0.2f);
//     }
//     public void Spawn() {
//         if (direction == Direction.Top) {
//         rand = Random.Range(0, variants.Top.Length);
//         Instantiate(variants.topRooms[rand], transform.position, variants.topRooms[rand].transform.rotation);
//         }
//         else if (direction == Direction.Down) {
//         rand = Random.Range(0, variants.Top.Length);
//         Instantiate(variants.downRooms[rand], transform.position, variants.downRooms[rand].transform.rotation);
//         }
//         else if (direction == Direction.Right) {
//         rand = Random.Range(0, variants.Top.Length);
//         Instantiate(variants.rightRooms[rand], transform.position, variants.rightRooms[rand].transform.rotation);
//         }
//         else if (direction == Direction.Left) {
//         rand = Random.Range(0, variants.Top.Length);
//         Instantiate(variants.leftRooms[rand], transform.position, variants.leftRooms[rand].transform.rotation);
        
//         }
//         spawned = true;
//     }
//     private void OnTriggerStay2D(Collider2D other) {
//         if (other.CompareTag("RoomPoint") && other.GetComponent<RoomSpawner>().spawned) {
//             Destroy(gameObject);
//         }
//     }
//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
