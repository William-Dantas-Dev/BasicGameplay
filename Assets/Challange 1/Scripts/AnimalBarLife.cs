using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalBarLife : MonoBehaviour
{
    [SerializeField] private Image barLife;
    [SerializeField] private float fullLife;
    private float life;
    void Start()
    {
        life = fullLife;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shoot"))
        {
            life--;
            barLife.fillAmount = life / fullLife;
            if(life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
