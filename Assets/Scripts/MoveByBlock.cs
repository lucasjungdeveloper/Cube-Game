using UnityEngine;

public class MoveByBlock : MonoBehaviour
{
    void movePlayer(Vector3 direction)
    {
        int layermask = ~(1 << 8); // Layer of colliders he can pass through (should include himself)

        if (!Physics.Raycast(transform.position, direction, 1)){
        transform.position += direction;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            movePlayer(Vector3.right);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            movePlayer(Vector3.left);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            movePlayer(Vector3.forward);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            movePlayer(Vector3.back);

        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = new Vector3(20f, 0.5f, 20f);

    }
}