using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;             //플레이어 이동속도

    public float minx = -14f;                //플레이어가 움직일 수 있는 범위
    public float maxX = 14f;
    public float minZ = -14f;
    public float maxZ = 14f;
    
    //float값 대신 int로 넣어도 유니티가 계산해서 자연스럽게 소숫점을 버리지 않고 나온다 or 속도값이라 달라도 괜찮을수도 있다.

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3(x, 0f, z).normalized;

        Vector3 nextPosition = transform.position + moveDir * moveSpeed * Time.deltaTime;

        nextPosition.x = Mathf.Clamp(nextPosition.x, minx, maxX);
        nextPosition.z = Mathf.Clamp(nextPosition.z, minZ, maxZ);

        transform.position = nextPosition;  

        if (moveDir != Vector3.zero)
        {
            transform.forward = moveDir;
            //rigidbody 안쓰는 이유:좌표 계산 방식으로 이동하기 때문에 직접 이동방식으로 이동하기가 더 쉽고 더 효율적이다.
        }
    }
}
