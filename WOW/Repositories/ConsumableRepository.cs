namespace WOW.Repositories
{
    public class ConsumableRepository
    {
        private List<Consumable> consumables = new();

        public bool Add(Consumable model)
        {
            try
            {
                consumables.Add(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Consumable model)
        {
            try
            {
                consumables.Remove(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Consumable model)
        {
            try
            {
                Consumable? oldModel = consumables.SingleOrDefault(x => x.Id == model.Id);
                if (oldModel != null)
                {
                    consumables.Remove(oldModel);
                    consumables.Add(model);
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

        public List<Consumable> Get() => consumables;
    }
}
