using AuthDemo.Shared.Models;

namespace AuthDemo.Server.Data.Interfaces
{
    public interface IContactsRepo
    {
        Task<List<Contact>> GetContactsAsync();
        Task<Contact?> GetContactAsync(int id);
        Task<Contact?> SaveContactAsync(Contact contact);
        Task DeleteContactAsync(Contact contact);
    }
}
