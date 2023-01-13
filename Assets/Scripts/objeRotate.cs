using UnityEngine;

public class objeRotate : MonoBehaviour
{
    public float rotationSpeed = 50f;
    private Quaternion rotation;

    void Start()
    {
        //create rotation around x-axis
        rotation = Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.forward);
        //Vector3.right x ekseni, Vector3.forward y ekseni, Vector3.up z ekseni
    }
    void Update()
    {
        //apply rotation to the cylinder
        transform.rotation *= rotation;
    }
}