using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapsuleController : MonoBehaviour
{
    private Camera mainCamera;
    private Transform myTransform;

    [SerializeField] private Text angleText;
    [SerializeField] private float minAngle = 6f;
    [SerializeField] private float maxAngle = 50f;
    [HideInInspector] public float finalAngle;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Rotation
        Vector3 mousePos = Input.mousePosition;
        Vector3 objectPos = mainCamera.WorldToScreenPoint(transform.position);
        mousePos.x -= objectPos.x;
        mousePos.y -= objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        if (angle >= minAngle && angle <= maxAngle)
        {
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            angleText.text = $"Angulo: {angle:F2}°";
        }

        // Send angle to another script
        if (Input.GetMouseButtonDown(0))
        {
            finalAngle = angle;
            //enabled = false; // (Optional) Turn off update() after launching the projectile
        }
    }
}
