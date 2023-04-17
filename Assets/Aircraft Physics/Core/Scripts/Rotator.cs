using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis((200+speed) * Time.deltaTime , Vector3.forward);
    }
}
