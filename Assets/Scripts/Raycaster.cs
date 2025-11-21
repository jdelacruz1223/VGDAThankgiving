using UnityEngine;

public class Raycaster : MonoBehaviour
{
    LayerMask layerMask;
    void Awake()
    {
        layerMask = LayerMask.GetMask("Turkey");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity) && Input.GetButtonDown("Fire1"))
        {
            if(hit.collider.gameObject.CompareTag("Turkey"))
            {
                Debug.Log("turkey");

            }
        }
    }
}
