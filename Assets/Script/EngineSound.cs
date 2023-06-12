using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSound : MonoBehaviour
{
    private Rigidbody car;
    private AudioSource audioExhaust;

    public float minSpeed,maxSpeed;
    private float speed;

    public float minExhaust, maxExhaust;
    private float exhaustCar;

    private void Start() {
        audioExhaust = GetComponent<AudioSource>();
        car = GetComponent<Rigidbody>();
    }

    private void Update() {
        Sound();
    }

    void Sound(){
        speed = car.velocity.magnitude;
        exhaustCar = car.velocity.magnitude / 50f;

        if(speed < minSpeed){
            audioExhaust.pitch = minExhaust;
        }

        if(speed > minExhaust && speed < maxExhaust){
            audioExhaust.pitch = minExhaust + exhaustCar;
        }

        if(speed > maxExhaust){
            audioExhaust.pitch = maxExhaust;
        }
    }
}
