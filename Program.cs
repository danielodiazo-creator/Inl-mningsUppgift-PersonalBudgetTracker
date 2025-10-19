namespace InlämningsUppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuHelper menu = new MenuHelper();  //Här skapar jag en object av klass MenuHelper
                                                 //som ska tillåta oss använda klassens properties och metoder,
                                                 //i detta fall metoden Menu.
                                                 
            menu.Menu();  
        }
    }
}
