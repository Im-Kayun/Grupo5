namespace ParticipationRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Choose Student to Answer Question");
            Console.WriteLine("2) Get Random Groups Composition");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                    StudentToAnswer();
                    return true;
                case "2":
                    GroupsComposition();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
 
        private static int Input()
        {
            Console.Write("How many people per group?");
            return Convert.ToInt32(Console.ReadLine());
        }
 
        private static void StudentToAnswer()
        {
            var students = new List<string>(){};
            students.Add("AFONSO ALMEIDA");
            students.Add("PAULO HENRIQUES");
            students.Add("NUNO PEREIRA");
            students.Add("DANIEL NOGUEIRA");
            students.Add("PEDRO MARQUES");
            students.Add("BRUNO MOREIRA");
            students.Add("PEDRO MONTEIRO DA ROCHA");
            students.Add("JOÃO COSTA");
            students.Add("LUÍS MOREIRA");
            students.Add("BRUNO LOPES");
            students.Add("MATHEUS SILVA");
            students.Add("CRISTIANO LOUÇÃO");
            students.Add("DIOGO SABINO");
            students.Add("GONÇALO FREITAS");
            students.Add("BRUNO MAGALHÃES");
            students.Add("GONÇALO PEREIRA");
            students.Add("NUNO FERRAZ");
            students.Add("DIOGO SILVA");
            students.Add("SIMONE SANTOS");
            students.Add("RAFAEL SILVA");
            students.Add("PEDRO MARTINS");
            students.Add("PEDRO NEVES");
            students.Add("TIAGO PINTO");
            students.Add("GUSTAVO RIBEIRO");
            students.Add("JOÃO BARROS");
            students.Add("PEDRO COSTA");
            students.Add("MARCOS RIBEIRO");
            students.Add("LEANDRO LUZ");
            students.Add("FRANCISCO DIAS");
            students.Add("LEONARDO ANDRADE");

            //Get Random Value to find student
            //Este é outro comentário que me tinha esquecido. 
            var random = new Random(DateTime.Now.Millisecond);
            var  index = random.Next(students.Count);
            
            Console.WriteLine(students[index]);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
 
        private static void GroupsComposition()
        {
            var students = new List<string>(){};
            students.Add("AFONSO ALMEIDA");
            students.Add("PAULO HENRIQUES");
            students.Add("NUNO PEREIRA");
            students.Add("DANIEL NOGUEIRA");
            students.Add("PEDRO MARQUES");
            students.Add("BRUNO MOREIRA");
            students.Add("PEDRO MONTEIRO DA ROCHA");
            students.Add("JOÃO COSTA");
            students.Add("LUÍS MOREIRA");
            students.Add("BRUNO LOPES");
            students.Add("MATHEUS SILVA");
            students.Add("CRISTIANO LOUÇÃO");
            students.Add("DIOGO SABINO");
            students.Add("GONÇALO FREITAS");
            students.Add("BRUNO MAGALHÃES");
            students.Add("GONÇALO PEREIRA");
            students.Add("NUNO FERRAZ");
            students.Add("DIOGO SILVA");
            students.Add("SIMONE SANTOS");
            students.Add("RAFAEL SILVA");
            students.Add("PEDRO MARTINS");
            students.Add("PEDRO NEVES");
            students.Add("TIAGO PINTO");
            students.Add("GUSTAVO RIBEIRO");
            students.Add("JOÃO BARROS");
            students.Add("PEDRO COSTA");
            students.Add("MARCOS RIBEIRO");
            students.Add("LEANDRO LUZ");
            students.Add("FRANCISCO DIAS");
            students.Add("LEONARDO ANDRADE");
            
            Console.Clear();

            var membersPerTeam = Input();

            var teamCount = students.Count / membersPerTeam;
            var teams = new List<String[]>();

            //This for cycle will create as many groups as needed
            for (var i = 0; i < teamCount; i++)
            {
                //This for cycle will create team composition
                String[] team = new String[membersPerTeam];
                for (var j = 0; j < membersPerTeam; j++)
                {
                    var random = new Random(DateTime.Now.Millisecond);
                    var  index = random.Next(students.Count);
                    var teamMember = students[index];
                    team[j] = teamMember;
                    students.Remove(teamMember);
                }
                teams.Add(team);
            }

            //Conta o número de equipas a ser criadas e apresenta os respetivos membros
            for(var i=0;i<teams.Count;i++)
            {
                var team = teams[i];
                var groupNr = i+1;
                Console.WriteLine("###################    Grupo" + groupNr + "    ###################");
                for(var j=0; j < team.Length; j++)
                {
                    Console.WriteLine(team[j]);
                }
            }

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}