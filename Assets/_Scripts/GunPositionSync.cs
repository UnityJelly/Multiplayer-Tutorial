using UnityEngine;
using UnityEngine.Networking;

public class GunPositionSync : NetworkBehaviour
{
    [SerializeField] Transform cameraTransform;
    [SerializeField] Transform handMount;
    [SerializeField] Transform gunPivot;
    [SerializeField] float threshhold = 10f;
    [SerializeField] float smoothing = 5f;

    [SyncVar] float pitch;
    Vector3 lastOffset;
    float lastSyncedPitch;

    void Start()
    {
        if (isLocalPlayer)
            gunPivot.parent = cameraTransform;
    }
}
