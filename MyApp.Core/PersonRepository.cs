namespace MyApp.Core
{
    public class PersonRepository
    {
        public Person GetPerson()
        {
            //string s = await new HttpClient().GetStringAsync("https://jsonplaceholder.typicode.com/users");
            //JsonConvert.DeserializeObject<IEnumerable<Person>>(s);
            return new Person("John", "Doe");
        }
    }
}
