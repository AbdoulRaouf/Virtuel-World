using UnityEngine;

public class CharacterAiming : MonoBehaviour
{
    float turnSpeed = 15f;
    float CamAngle;
    [SerializeField] float aimDuration = .3f;
    
    
    Camera mainCamera;
    void Start()
    { 
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
       
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, CamAngle,0), turnSpeed*Time.deltaTime);
    }
    private void Update()
    {
        CamAngle = mainCamera.transform.rotation.eulerAngles.y;
    }
   
}
