using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public float xRange;
    public GameObject projectilePrefab;
    private CanvasController canvasController;
    void Start()
    {
        canvasController = FindObjectOfType<CanvasController>();
    }

    
    void Update()
    {
        KeepPlayerBounds();
        PlayerMovement();
        ShootingProjectilePrefab();
    }

    private void ShootingProjectilePrefab()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }



    private void PlayerMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * Time.deltaTime * speed);
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    private void KeepPlayerBounds()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animals"))
        {
            Destroy(other.gameObject);
            canvasController.ReceiveDamage();
        }
    }
}
