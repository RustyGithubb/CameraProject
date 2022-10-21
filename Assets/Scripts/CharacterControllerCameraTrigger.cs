using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerCameraTrigger : MonoBehaviour
{

    public GameObject Pawn, CameraObject;
    public bool CanFolloxPawn;
    public float YMediant, YMax, Ymin;

    private void OnTriggerEnter(Collider other)
    {
        print(other);
        if (other.GetComponent<MovementCharacter2D>() !=  null)
        {
            print("ouais");
            CameraObject.GetComponent<CameraCharacter2D>().CanFollow = CanFolloxPawn;
            CameraObject.GetComponent<CameraCharacter2D>().Ymediant = YMediant;
            CameraObject.GetComponent<CameraCharacter2D>().YMax = YMax;
            CameraObject.GetComponent<CameraCharacter2D>().Ymin = Ymin;
        }
    }
}
