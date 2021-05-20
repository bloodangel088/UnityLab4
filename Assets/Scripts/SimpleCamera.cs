using UnityEngine;

public class SimpleCamera : MonoBehaviour
{
    public Transform player;

    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = player.InverseTransformPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        var currentPosition = player.TransformPoint(position);
        transform.position = currentPosition;
        transform.LookAt(player);
    }
}