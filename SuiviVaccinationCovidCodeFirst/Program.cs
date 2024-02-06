using SuiviVaccinationCovidCodeFirst.Modeles;

namespace SuiviVaccinationCovidCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entrez votre numéro d'assurance maladie : ");
            
            string numero = Console.ReadLine();


            Vaccin pfizer = new() { Nom = "Pfizer-BioTech" };
            Vaccin moderna = new() { Nom = "Moderna" };


            Dose dose1 = new ()
            {
                Date = new DateTime(2022,04,29),
                NAMPatient = "LAMP1757487",
                Vaccin = pfizer
            };

            Dose dose2 = new()
            {
                Date = new DateTime(2022, 08, 12),
                NAMPatient = "LAMP1757487",
                Vaccin = moderna
            };

            Dose dose3 = new()
            {
                Date = new DateTime(2023, 02, 25),
                NAMPatient = "LAMP1757487",
                Vaccin = pfizer
            };

            Immunisation variant1 = new Covid19()
            {
                Variant = "Beta",
                Date = new DateTime(2022,04,23),
                NAMPatient = "LAMP1757487"

            };

            Immunisation variant2 = new Covid19()
            {
                Variant = "Gamma"
            };
            Immunisation variant3 = new Covid19()
            {
                Variant = "Omicron"
            };


            VaccinationContext context = new();

            context.Doses.Add(dose1);
            context.Doses.Add(dose2);
            context.Doses.Add(dose3);
         
            context.SaveChanges();


            
            context.Remove(dose2);
            dose1.Vaccin = pfizer;
            context.SaveChanges();

            foreach (Dose dose in context.Doses)
            {
                Console.WriteLine(dose);
                Console.ReadKey();
            }
        }
    }
}