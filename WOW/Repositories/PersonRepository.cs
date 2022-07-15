namespace WOW.Repositories
{
    public class PersonRepository
    {
        private List<Person> persons = new();

        public bool Add(Person model)
        {
            try
            {
                persons.Add(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Person model)
        {
            try
            {
                persons.Remove(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Person model)
        {
            try
            {
                Person? oldModel = persons.SingleOrDefault(x => x.Id == model.Id);
                if (oldModel != null)
                {
                    persons.Remove(oldModel);
                    persons.Add(model);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Person> Get() => persons;
    }
}
