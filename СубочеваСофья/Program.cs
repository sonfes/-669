   namespace SubochevaVar25Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Я чат-бот из 90-х. Чем могу вам помочь?");
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "выход")
                {
                    Console.WriteLine("До свидания!");
                    break;
                }
                string response = GenerateResponse(userInput);
                Console.WriteLine(response);
            }
        }

        static string GenerateResponse(string input)
        {
            if (input.Contains("привет"))
                return "Привет! Как дела?";
            else if (input.Contains("что ты можешь?"))
                return "Я могу рассказать тебе о программировании!";
            else
                return "Извини, я не понимаю.";
        }
    }
}