using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform objetivo;
    public float distancia = 8f;
    public float distanciaMin = 3f;
    public float distanciaMax = 15f;
    public float altura = 1.5f;
    public float sensibilidad = 2f;
    public float velocidadZoom = 3f;

    private float yaw;
    private float pitch = 15f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        yaw = transform.eulerAngles.y;
    }

    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * sensibilidad;
        pitch -= Input.GetAxis("Mouse Y") * sensibilidad;
        pitch = Mathf.Clamp(pitch, -20f, 60f);

        distancia -= Input.mouseScrollDelta.y * velocidadZoom;
        distancia = Mathf.Clamp(distancia, distanciaMin, distanciaMax);

        Quaternion rotacion = Quaternion.Euler(pitch, yaw, 0f);
        Vector3 punto = objetivo.position + Vector3.up * altura;

        transform.position = punto - rotacion * Vector3.forward * distancia;
        transform.rotation = rotacion;
    }
}