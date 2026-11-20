namespace Cat_name
{
    public class Cat_name
    {
        public string Name;
        public int Age;
        public Cat_name(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("고양이 이름은 " + Name + "이고, 나이는 " + Age + "살입니다.");
        }
        class MainClass {
            public static void Main(string[] args)
            {
                Cat_name cat = new Cat_name("나비", 3);
                Cat_name cat2 = new Cat_name("비비", 5);
                    }
        }
            
        
    }
}
