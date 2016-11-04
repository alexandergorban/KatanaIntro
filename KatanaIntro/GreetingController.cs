namespace KatanaIntro
{
    public class GreetingController
    {
        public Greeting Get()
        {
            return new Greeting { Text = "Hello World!"};
        }
    }
}
