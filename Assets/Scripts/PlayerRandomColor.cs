using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomColor : MonoBehaviour {
 
    new Renderer renderer;
    float time = 0;
    Color color;

    void Awake() {
        renderer = GetComponent<Renderer>();
        color = new Color(Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f));
    }

    void Update() {

        renderer.material.color = Color.Lerp(renderer.material.color, color, time);
        if (time >= 1f) {
            time = 0;
            color = new Color(Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f));
        }
        time += Time.deltaTime;
    }
}
