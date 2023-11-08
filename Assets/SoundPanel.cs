using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageAnimator : MonoBehaviour
{
    public GameObject imageWindow;
    private Animator animator;

    private void Start()
    {
        animator = imageWindow.GetComponent<Animator>();
        imageWindow.SetActive(false); // 이미지 창을 초기에 비활성 상태로 설정
    }

    public void ShowImage()
    {
        if (!imageWindow.activeSelf)
        {
            imageWindow.SetActive(true); // 이미지 창을 활성화
            animator.SetTrigger("doShow"); // "doShow" 애니메이션을 실행
        }
    }

    public void HideImage()
    {
        if (imageWindow.activeSelf)
        {
            animator.SetTrigger("doHide"); // "doHide" 애니메이션을 실행
        }
    }
}
