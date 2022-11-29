using AuthDemo.Server.Data.Interfaces;
using AuthDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Server.Data.Repository
{
    public class ContactsRepo : IContactsRepo
    {
        private ApplicationDbContext _context;

        public ContactsRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contact>> GetContactsAsync()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<Contact?> GetContactAsync(int id)
        {
            return await _context.Contacts.Where(c => c.Id == id).FirstOrDefaultAsync();
        }


        public async Task<Contact?> SaveContactAsync(Contact contact)
        {
            if(contact.Id == 0) //New contact
            {
                _context.Add(contact);
            }
            else //Update old contact
            {
                _context.Entry(contact).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
            return contact;
        }

        public async Task DeleteContactAsync(Contact contact)
        {
            _context.Remove(contact);
            await _context.SaveChangesAsync();
        }


    }
}
