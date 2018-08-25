using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mars
{
	public class GameOver : MonoBehaviour
	{
		public GameObject left;
		public GameObject terra;
		public GameObject err;
		private void Awake()
		{
			left.SetActive(false);
			terra.SetActive(false);
			err.SetActive(false);
		}

		// Use this for initialization
		void Start ()
		{
			if(MarsClicker.GetGameEnd == GameEnd.left)
				left.SetActive(true);
			else if(MarsClicker.GetGameEnd == GameEnd.terraformed)
				terra.SetActive(true);
			else
				err.SetActive(true);

		}
	
		// Update is called once per frame
		void Update () {
		
		}

		public void Exit()
		{
			Application.Quit();
		}

	}
}