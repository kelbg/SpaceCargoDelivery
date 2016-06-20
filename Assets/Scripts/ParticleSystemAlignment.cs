﻿using UnityEngine;
using System.Collections;

public class ParticleSystemAlignment : MonoBehaviour {
    private ParticleSystem particles;

	void Start () {
        particles = GetComponent<ParticleSystem>();
        ParticleSystem.ShapeModule shape = particles.shape;
        Vector3 topAlignment = new Vector3(
            GameController.current.screenWidth, 
            shape.box.y,
            shape.box.z
        );

        transform.position = new Vector3(
            transform.position.x, 
            GameController.current.screenHeight / 2 + shape.box.y / 2,
            transform.position.z
        );
        shape.box = topAlignment;
    }
}
