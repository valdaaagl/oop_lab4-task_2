class Program
{
    static void Main(string[] args)
    {
        Pupil bob = new Pupil("Dima");
        Pupil bill = new BadPupil("Daria");
        Pupil mariz = new GoodPupil("Maria");  
        Pupil vozniak = new ExellentPupil("Anton");         
 
        var firstClassRoom = new ClassRoom(bill);
        var secondClassRoom = new ClassRoom(bill, vozniak);
        var thirdClassRomm = new ClassRoom(bill, vozniak, mariz);
        var forthClassRomm = new ClassRoom(bill, vozniak, mariz, bob);
        forthClassRomm.GetPupilsRead();
 
        Console.ReadLine();
    }
}

public class Pupil
    {
        public string PupilName { get; private set; }
        public Pupil(string name)
        {
            PupilName = name;
        }
     
        private string GetPupilNameAndStatus()
        {
            return String.Format("{0} {1}", GetType().Name, PupilName);
        }
     
        public virtual void Read()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Reading");
        }
     
        public virtual void Write()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Writting");
        }
     
        public virtual void Relax()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Relaxing");
        }
     
        public virtual void Study()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Studying");
        }
    }
     
public class ExellentPupil : Pupil
{
    public ExellentPupil(string name)
        : base(name)
    { }
    public override void Read()
    {
        Console.WriteLine("{0} reads more than usual pupil", PupilName);
    }
}
     
public class GoodPupil : Pupil
{
    public GoodPupil(string name)
        : base(name)
    { }
}
     
        public class BadPupil : Pupil
        {
            public BadPupil(string name)
                : base(name)
            { }
        }
     
public class ClassRoom
{
    public readonly List<Pupil> Pupils = new List<Pupil>();
     
    public ClassRoom(params Pupil[] pupils)
    {
        Pupils.AddRange(pupils);
    }
     
    public void GetPupilsRead()
    {
        foreach (var pupil in Pupils)
        {
            pupil.Read();
        }
    }
}
