using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deathZone = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 
        if (transform.position.x < deathZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
            }
}
  