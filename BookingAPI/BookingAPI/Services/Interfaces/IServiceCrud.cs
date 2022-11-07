namespace BookingAPI.Services.Interfaces
{

    public interface IServiceCrud<T,TPost,TGet,TPut>
    {
        public T Create(TPost objectValue);
        public IEnumerable<TGet> GetAll();
        public T GetById(int id);

        public TGet Update(int id, TPut book);

        public void DeleteById(int id);



    }

}
