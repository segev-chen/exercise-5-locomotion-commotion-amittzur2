using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomActionBasedController : ActionBasedController
{
    public float k = 0;

    protected override void UpdateTrackingInput(XRControllerState controllerState)
    {
        base.UpdateTrackingInput(controllerState);

        // Move k units in the direction the controller is facing
        Vector3 forwardDirection = controllerState.rotation * Vector3.forward;
        controllerState.position +=  (forwardDirection * k);
    }

    public void SetK(float newK){
        k = newK;
    }
}
