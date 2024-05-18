using Roguelike.Contents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public float camMoveSpeed;
    public Vector2 canMoveAreaCenter;           //ī�޶� �̵� ���ɿ��� �߽�
    public Vector2 canMoveAreaSize;              //ī�޶� �̵� ���ɿ��� ũ��

    public float cameraHalfWidth;       //ī�޶��� ���� ���������� ���� ����
    public float cameraHalfHeight;      //ī�޶��� ���� ���������� ���� ����

    private void Awake()
    {
        cameraHalfHeight = Camera.main.orthographicSize;
        cameraHalfWidth = Screen.width * cameraHalfHeight / Screen.height;
    }

    private void LateUpdate()
    {
        FollowTarget();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(canMoveAreaCenter, canMoveAreaSize);
    }

    private void FollowTarget()
    {
        Vector3 targetPosition = new Vector3(target.position.x, this.transform.position.y, this.transform.position.z);
        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, camMoveSpeed * Time.deltaTime);

        float restrictionAreaX = canMoveAreaSize.x * 0.5f - cameraHalfWidth;
        float clampX = Mathf.Clamp(this.transform.position.x, -restrictionAreaX + canMoveAreaCenter.x, restrictionAreaX + canMoveAreaCenter.x);

        float restrictionAreaY = canMoveAreaSize.y * 0.5f - cameraHalfHeight;
        float clampY = Mathf.Clamp(this.transform.position.y, -restrictionAreaY + canMoveAreaCenter.y, restrictionAreaY + canMoveAreaCenter.y);

        this.transform.position = new Vector3(clampX, clampY, this.transform.position.z);
    }
}
