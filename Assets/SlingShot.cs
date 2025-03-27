using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SlingShot : MonoBehaviour
{
    public Transform Projectile;
    public Transform DrawFrom;
    public Transform DrawTo;
    
    public SlingShotString SlingShotString;
    public int NrDrawIncrements = 10;

    private Transform currentProjectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.A)) ;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawSlingShot(float speed)
    {
        currentProjectile = Instantiate(Projectile, DrawFrom.position, Quaternion.identity, transform);

        float waitTimeBetweenDraws = speed / NrDrawIncrements;
        
    }
}
