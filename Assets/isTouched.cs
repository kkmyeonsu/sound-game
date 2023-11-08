using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPlayAnimation : MonoBehaviour
{
    private Animation objectAnimation; // 오브젝트에 연결된 애니메이션 컴포넌트

    private Animator animator; // Animator 컴포넌트

    private void Start()
    {
        // 오브젝트에 연결된 애니메이션 컴포넌트 찾기
        objectAnimation = GetComponent<Animation>();

        // Animator 컴포넌트 찾기
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        Debug.Log("클릭 이벤트 발생");

        // 클릭한 오브젝트에 연결된 애니메이션 컴포넌트가 있다면 실행
        if (objectAnimation != null)
        {
            objectAnimation.Play();
        }

        // "Playanim" 트리거를 활성화하여 Animator 컨트롤러의 애니메이션 실행
        if (animator != null)
        {
            animator.SetTrigger("PlayAnim");
        }
    }
}
