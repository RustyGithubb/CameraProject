using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCharacter2D : MonoBehaviour
{

    public GameObject Pawn;
    public float _AdvanceValue, _Lag, YMax, Ymin, Yvalue, Ymediant;
    Vector3 _PositionPawn;
    float Zposition;
    public bool CanFollow;

    // Start is called before the first frame update
    void Start()
    {
        Zposition = transform.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(CanFollow)
        {
            if (Yvalue <= Ymin)
            {
                Yvalue = Ymin;
            }
            else
            {
                if (Yvalue >= YMax)
                {
                    Yvalue = YMax;
                }
                else
                {
                    Yvalue = Pawn.transform.position.y;
                }
            }

            if (Pawn.GetComponent<MovementCharacter2D>().Negative == false)
            {
                _PositionPawn = new Vector3(Pawn.transform.position.x + _AdvanceValue, Yvalue, Zposition);
            }
            else
            {
                _PositionPawn = new Vector3(Pawn.transform.position.x - _AdvanceValue, Yvalue, Zposition);
            }

            transform.position = Vector3.Lerp(transform.position, _PositionPawn, Time.deltaTime * _Lag);

        }
        else
        {

            Yvalue = Ymediant;

            if (Pawn.GetComponent<MovementCharacter2D>().Negative == false)
            {
                _PositionPawn = new Vector3(Pawn.transform.position.x + _AdvanceValue, Yvalue, Zposition);
            }
            else
            {
                _PositionPawn = new Vector3(Pawn.transform.position.x - _AdvanceValue, Yvalue, Zposition);
            }

            transform.position = Vector3.Lerp(transform.position, _PositionPawn, Time.deltaTime * _Lag);
        }


        
    }
}
