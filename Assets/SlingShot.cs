using UnityEngine;
using UnityEngine.VFX;

public class SlingShot : MonoBehaviour
{
    public Transform launchPoint;

    public GameObject projectile;

    public float launchForce = 500f;

    private GameObject currentProjectile;
    private Rigidbody projectileRb;
    private bool isDragging = false;
    private Vector3 initialPosition;
    
    void Start()
    {
        initialPosition = launchPoint.position;
    }

    
    void Update()
    {
      if (currentProjectile == null)
      {
          SpawnProjectile();
      }

      if (isDragging)
      {
          DragProjectile();
      }
      if (Input.GetMouseButton(0) && isDragging)
      {
          ReleaseProjectile();
      }
    }

    void SpawnProjectile()
    {
        currentProjectile = Instantiate(projectile, launchPoint.position, Quaternion.identity);
        projectileRb = currentProjectile.GetComponent<Rigidbody>();
        projectileRb.isKinematic = true;
    }

    void DragProjectile()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        currentProjectile.transform.position = new Vector3(mousePos.x, mousePos.y, initialPosition.z);
    }

    void ReleaseProjectile()
    {
        isDragging = false;
        projectileRb.isKinematic = false;
        Vector3 launchDirection = (initialPosition - currentProjectile.transform.position).normalized;
        projectileRb.AddForce(launchDirection * launchForce);
        currentProjectile = null;
    }

    void OnMouseDown()
    {
        isDragging = true;
    }
}
