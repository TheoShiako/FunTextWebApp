namespace FunTextLibrary.Interfaces;

public interface ITranslatorsData
{
    Task Delete(int Id);
    Task<IEnumerable<TranslatorModel>> Get(int? Id = null);
    Task Insert(TranslatorModel model);
    Task Update(TranslatorModel model);
}