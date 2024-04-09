using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject platform;
    public int numberOfEntities = 5; // Number of entities to spawn
    public int pozitionOfP1 = -1;
    public int pozitionOfP2 = -1;
    public int pozitionOfP3 = -1;

    private float radius = 1f; // Radius of the circle

    // Start is called before the first frame update
    void Start()
    {
        SpawnEntities();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEntities()
    {
        Vector3 centerPosition = Vector3.zero; //platform.transform.position;
        float angleStep = 360f / numberOfEntities; // Angle between each entity
        float ballScale = 1f;

        for (int i = 0; i < numberOfEntities; i++)
        {
            float angle = i * angleStep; // Calculate angle for this entity

            // Calculate position in circle using trigonometry
            float x = centerPosition.x + Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
            float y = centerPosition.y + platform.transform.localScale.y + ballScale + 0.1f;
            float z = centerPosition.z + Mathf.Sin(angle * Mathf.Deg2Rad) * radius;

            // Spawn sphere at calculated position
            GameObject newSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            newSphere.gameObject.AddComponent<Rigidbody>();
            newSphere.transform.position = new Vector3(x, y, z);
            newSphere.transform.localScale = new Vector3(ballScale, ballScale, ballScale); // Set scale as needed

            if (i == pozitionOfP1)
            {
                newSphere.gameObject.AddComponent<PlayerBall1>();
                newSphere.gameObject.tag = "Player1";
            }
            else if (i == pozitionOfP2)
            {
                newSphere.gameObject.AddComponent<PlayerBall2>();
                newSphere.gameObject.tag = "Player2";
            }
            else if (i == pozitionOfP3)
            {
                newSphere.gameObject.AddComponent<PlayerBall3>();
                newSphere.gameObject.tag = "Player3";
            }
            else
            {
                newSphere.gameObject.AddComponent<BallAI>();
                newSphere.gameObject.tag = "Bot" + i;
            }
        }
    }
}
