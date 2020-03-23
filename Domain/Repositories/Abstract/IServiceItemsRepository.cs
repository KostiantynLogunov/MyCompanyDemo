using MyCompany.Domain.Entities;
using System;
using System.Linq;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems(); // зробити виборку всіх service
        ServiceItem GetServiceItemById(Guid id);   // зробити виборку всіх service by id
        void SaveServiceItem(ServiceItem entity);  // зберегти зміни
        void DeleteServiceItem(Guid id);           // видалити по ІД
    }
}
