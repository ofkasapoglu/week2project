using Calisma;

namespace Calisma;

class program
{
	public static void Main()
	{
		Employee employee = new Employee(18,"Omer","sdds",0,"Kasapoglu");
		
		Addd ad = new Addd();

		ad.CreateAdd(employee);

		Console.WriteLine(ad.ReadId(0));

        ad.CreateAdd(employee);
    }
}




