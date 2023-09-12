class Program{
    string? Name;
    int age;
    string? pass;
    bool result=false; 

    public void getStudentDetails(){
        Console.Write("Enter the student name: ");
        Name = Console.ReadLine();
        Console.Write("Enter student Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Student passed 12th?(yes/no): ");
        pass = Console.ReadLine();
        if(pass=="yes" || pass=="Yes"){
            result = true;
        }
    }

    public void checkEligibility(){
        if(age<20 && result==true){
            Console.Write($"The student {Name} is eligible to join");
        }
        else{
            Console.Write($"The student {Name} is {age} years old, so not eligible");
        }
    }

    public static void Main(string[] args){
        Program ob = new Program();
        ob.getStudentDetails();
        ob.checkEligibility();
    }
}