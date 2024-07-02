namespace PetFinder.Domain.Entities
{
	public class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public DateTimeOffset CreatedAt { get; set; }
		public DateTimeOffset UpdatedAt { get; set; }

		public Animal(string name)
		{
			Name = name;
		}
	}
}
