using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnspeed;
    public float horizonalInput;
    public float fowardInput;

    public Camera frontCamera;
    public Camera backCamera;
    public KeyCode switchKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizonalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime*speed*fowardInput);
        transform.Rotate(Vector3.up, turnspeed * horizonalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            frontCamera.enabled= !frontCamera.enabled;
            backCamera.enabled= !backCamera.enabled;
        }
    }
}
