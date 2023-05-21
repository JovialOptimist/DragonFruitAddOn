namespace MauiApp2;

public partial class MainPage : ContentPage
{
	public List<User> buddies;
	
	public MainPage()
	{
		InitializeComponent();

		User temp = new User();
		User temp2 = new User("John Cena", 1);
        User temp3 = new User("Bat Man", 2);
        User temp4 = new User("God Himself", 3);
        User temp5 = new User("Professor Musselman", 9001);
		

        buddies = new List<User>() { temp, temp2, temp3, temp4, temp5 };

		candidates.ItemsSource = buddies;

	}


    public class User
	{
		public string name;
		public int exampleOtherData;

		public User()
		{
			name = "Fake Name";
			exampleOtherData = -99;
		}

		public User(string name, int exampleOtherData)
		{
			this.name = name;
			this.exampleOtherData = exampleOtherData;
		}

        public override string ToString()
        {
			return name + ", " + exampleOtherData;
        }
    }
}

