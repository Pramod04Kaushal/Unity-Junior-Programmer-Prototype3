using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public Vector3 startPos; // Starting position of the background
    private float repeatWidth; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; // Set the starting position to the current position of the background
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos; // Reset the position of the background to the starting position
        }
        
    }
}
