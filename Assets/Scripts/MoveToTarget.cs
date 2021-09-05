using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}