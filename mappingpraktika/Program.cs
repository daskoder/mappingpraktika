using AutoMapper;

namespace mappingpraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("auto mapping");

            auto bmw = new auto();

            bmw.Year = 1995;
            bmw.Name = "E38";
            bmw.Title = "7 series";
            bmw.Description = "Black";

            autoDto dto = new autoDto();
            dto.Year = bmw.Year;
            dto.Name = bmw.Name;
            dto.Title = bmw.Title;
            dto.Description = "Red";

            Console.WriteLine("Which car? 1 or 2.");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine(bmw.Year + " " + bmw.Name + " " + bmw.Title + " " + bmw.Description);
            }
            if (a == 2) 
             {
                Console.WriteLine(dto.Year + " " + dto.Name + " " + dto.Title + " " + dto.Description);
            }
            
        }
    }
    public class auto
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
    public class autoDto
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
