﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{

	public class Drawer_Pull_X : MonoBehaviour
	{

		public Animator pull_01;
		public bool open;
		public Transform Player;

		void Start()
		{
			open = false;
		}

		public void Interact()
		{
			{
				if (Player)
				{
					float dist = 0;
					if (dist < 10)
					{
						//print("object name");
						print("Interacting with: " + gameObject.name);
						if (open == false)
						{
								StartCoroutine(opening());
								
						}
						else
						{
							if (open == true)
							{
								StartCoroutine(closing());
								
							}

						}

					}
				}

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			pull_01.Play("openpull_01");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			pull_01.Play("closepush_01");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}