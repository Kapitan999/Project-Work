using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFireV01 : MonoBehaviour
{
    [SerializeField] GameObject attackPrefab = null;
    [SerializeField] GameObject attack1 = null, attack2 = null;
    [SerializeField] Transform gun = null;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
//      if (Input.GetMouseButtonDown(0))
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(attackPrefab, gun.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attackPrefab = attack1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attackPrefab = attack2;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickup"))
        {
            attackPrefab = attack2;
        }
    }
}
