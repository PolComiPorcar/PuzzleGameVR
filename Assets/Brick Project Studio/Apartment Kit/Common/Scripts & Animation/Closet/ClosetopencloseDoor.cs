using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class ClosetopencloseDoor : MonoBehaviour
	{

		public Animator Closetopenandclose;
		public bool open;
		public Transform Player;

		void Start()
		{
			open = false;
		}

		public void InteractDoor()
		{
			{
				if (Player)
				{
					float dist = 0;
					if (dist < 15)
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

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			Closetopenandclose.Play("ClosetOpening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			Closetopenandclose.Play("ClosetClosing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}