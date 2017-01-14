using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
	public int minDistance = 10;
	public Color idleColor = Color.white;
	public Color closeColor = Color.blue;

	private GameObject player;
	private ParticleSystem ps;
	private ParticleSystem.Particle[] particles;

	void Start () {
		player = GameObject.Find("Player");
		ps = GetComponent<ParticleSystem>();
		particles = new ParticleSystem.Particle[ps.maxParticles];
	}

	private void LateUpdate() {
		int numParticlesAlive = ps.GetParticles(particles);

		for (int i = 0; i < numParticlesAlive; i++) {
			if (Vector3.Distance(particles[i].position, player.transform.position) < minDistance) {
				Debug.Log ("Bonjour");
				particles[i].startColor = closeColor;
			}
			else {
				particles[i].startColor = idleColor;
			}
		}

		ps.SetParticles(particles, numParticlesAlive);
	}
}