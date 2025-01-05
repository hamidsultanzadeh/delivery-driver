using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(37, 242, 32, 255);
    [SerializeField] Color32 defaultColor = new Color32(255, 255, 255, 255);

    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Damnn!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) {
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        } else if (other.tag == "Customer" && hasPackage) {
            hasPackage = false;
            spriteRenderer.color = defaultColor;
        }
    }

}
