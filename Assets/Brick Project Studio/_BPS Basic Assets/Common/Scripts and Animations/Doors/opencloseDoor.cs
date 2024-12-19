using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{
		public SoundJordi SoundGenerator;
		public Animator openandclose;
		public bool open;
		public Transform Player;
		public bool isLocked = false;

		void Start()
		{
			open = false;
		}

		public void InteractDoor()
		{
			if (Player)
			{
				float dist = 0;
				if (dist < 15 && !isLocked)
				{
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

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}

		public void Unlock() {
			SoundGenerator.PlaySound1();
			isLocked = false;
			Debug.Log("porta desbloquejada");
		}

	}
}