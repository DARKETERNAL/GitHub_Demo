using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomColor : MonoBehaviour {
 
    new Renderer renderer;
    float time = 0;
    float duration = 1.5f;
    Color color1;
    Color color2;

    void Awake() {
        renderer = GetComponent<Renderer>();
        color1 = renderer.material.color;
        color2 = new Color(Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f));
    }

    void Update() {

        renderer.material.color = Color.Lerp(color1, color2, time/ duration);
        if (time >= duration) {
            time = 0;
            color1 = color2;
            color2 = new Color(Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f));
        }
        time += Time.deltaTime;
    }
}
