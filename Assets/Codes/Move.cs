using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            position.y += speed * Time.deltaTime;
            transform.position = position;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= speed * Time.deltaTime;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed * Time.deltaTime;
            transform.position = position;
        } else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { 
            position.x -= speed * Time.deltaTime;
            transform.position = position;
        }
    }
}
