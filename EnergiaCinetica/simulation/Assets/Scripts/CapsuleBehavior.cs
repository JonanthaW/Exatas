using UnityEngine;
using UnityEngine.UI;

public class CapsuleBehavior : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireForce;
    [SerializeField] private Text mass;
    [SerializeField] private Text velocity;
    [SerializeField] private Text force;
    [SerializeField] private Text kineticEnergy;
    [SerializeField] private Text potentialEnergy;
    [SerializeField] private Text maximumHeight;
    [SerializeField] private Text timeFlight;

    private bool isFired;
    private Rigidbody2D projectileRigidbody;
    private CapsuleController angle;

    private void Start()
    {
        // Cache the Rigidbody2D component for better performance
        projectileRigidbody = ballPrefab.GetComponent<Rigidbody2D>();
        angle = GetComponent<CapsuleController>();
    }

    public void Fire()
    {
        if (isFired) return;

        GameObject projectile = Instantiate(ballPrefab, firePoint.position, firePoint.rotation);
        projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
        projectileRigidbody.AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        isFired = true;
        UpdateUI();
        StartCoroutine(BallRolling());
    }

    private void UpdateUI()
    {
        // Avoid accessing GetComponent() multiple times for better performance
        mass.text = $"Massa: {projectileRigidbody.mass}kg";
        velocity.text = $"Velocidade: {projectileRigidbody.velocity.magnitude}m/s";
        force.text = $"Forca: {fireForce}N";
        kineticEnergy.text = $"Energia cinetica: {(projectileRigidbody.mass * Mathf.Pow(projectileRigidbody.velocity.magnitude, 2) * 0.5f)}J";
        potentialEnergy.text = $"Energia potencial: {projectileRigidbody.mass * 9.81 * Mathf.Pow(projectileRigidbody.velocity.magnitude, 2) * Mathf.Pow(Mathf.Sin(angle.finalAngle * Mathf.PI / 180), 2) / (2 * 9.81):F2}J";
        maximumHeight.text = $"Altura maxima: {Mathf.Pow(projectileRigidbody.velocity.magnitude, 2) * Mathf.Pow(Mathf.Sin(angle.finalAngle * Mathf.PI / 180), 2) / (2 * 9.81):F2}m";
        timeFlight.text = $"Tempo de voo: {2 * projectileRigidbody.velocity.magnitude * Mathf.Sin(angle.finalAngle * Mathf.PI / 180) / 9.8:F3}sec";
    }

    private void Update()
    {
        if (isFired && projectileRigidbody != null)
        {
            // Avoid creating a new Vector3 object for better performance
            Camera.main.transform.position = new Vector3(projectileRigidbody.position.x, projectileRigidbody.position.y, -10);
        }
        else
        {
            Camera.main.transform.position = new Vector3(-510, 2, -1);
        }
    }

    private System.Collections.IEnumerator BallRolling()
    {
        yield return new WaitForSeconds(10);
        Destroy(projectileRigidbody.gameObject);
        isFired = false;
    }
}
