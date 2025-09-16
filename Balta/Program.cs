using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        public static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo CSharp", "c-sharp"));
            articles.Add(new Article("Artigo Dotnet", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("");
            }

            var courses = new List<Course>();
            courses.Add(new Course("Fundamentos OOP", "fundamentos-oop"));
            courses.Add(new Course("Fundamentos C#", "fundamentos-csharp"));
            courses.Add(new Course("Fundamentos Asp.Net", "fundamentos-aspnet"));

            var careers = new List<Career>();
            careers.Add(new Career("Especialista Dotnet", "especialista-dotnet"));
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courses.ElementAt(1));
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courses.ElementAt(2));
            careers.ElementAt(0).Items.Add(careerItem2);
            careers.ElementAt(0).Items.Add(careerItem);
            careers.ElementAt(0).Items.Add(careerItem3);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title + "\n");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var student = new Student();
            var payPalSubscription = new PayPalSubscription();
            student.CreateSubscription(payPalSubscription);
        }
    }
}
