using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10.Models
{
	internal class Lesson
	{
		public Lesson(string name, string description)
		{
			Name = name;
			Description = description;
		}

		public string Name { get; set; }
		public string Description { get; set; }
	}
}
