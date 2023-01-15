using UnityEngine;

public class levelgecis : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        canvas = GameObject.Find("CanvasName");
        canvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            canvas.SetActive(true);
        }
    }
}