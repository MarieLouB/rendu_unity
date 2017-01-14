using UnityEngine;
using System.Collections;

public class changeCamera : MonoBehaviour
{

    public Camera camera;
    public Camera camera2;
    public Camera camera3;

    void Start()
    {

        camera.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
    }

    void Update()
    {
        //This will toggle the enabled state of the two cameras between true and false each time
        if (Input.GetKeyUp(KeyCode.C))
        {
            camera.enabled = !camera.enabled;
            camera2.enabled = !camera2.enabled;
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            camera.enabled = !camera.enabled;
            camera3.enabled = !camera3.enabled;
        }
    }
}