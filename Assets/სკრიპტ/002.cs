using UnityEngine;

public class c002b : MonoBehaviour
{
    public float moveSpeed = 5f; // სიჩქარე წინსვლისთვის

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // წინ წასვლა W ღილაკზე
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
