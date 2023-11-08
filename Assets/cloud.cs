using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5f;        // 이동 속도
    public float moveDistance = 10f; // 이동할 거리
    public float repeatDistance = 20f; // 반복할 구간의 길이

    private Vector3 initialPosition; // 초기 위치

    void Start()
    {
        // 초기 위치 저장
        initialPosition = transform.position;
    }

    void Update()
    {
        // 오브젝트를 가로로 이동
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // 이동한 거리가 repeatDistance를 넘어가면 처음 위치로 돌아감
        if (Mathf.Abs(transform.position.x - initialPosition.x) >= repeatDistance)
        {
            // 현재 위치를 초기 위치로 재설정
            transform.position = initialPosition;
        }
    }
}
