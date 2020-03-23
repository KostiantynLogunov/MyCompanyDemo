using MyCompany.Domain.Entities;
using System;
using System.Linq;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields(); // зробити виборку всіх текстових полів
        TextField GetTextFieldById(Guid id);   // зробити виборку по індефікатору
        TextField GetTextFieldByCodeWord(string codeWord); // зробити виборку по кодовому слову
        void SaveTextField(TextField entity);  // зберегти зміни
        void DeleteTextField(Guid id);         // видалити по ІД
    }
}
