namespace MicrosoftWine
{
    public interface IHasLocalizationId
    {
        string LocalizationId { get; }
        // интерфейс обязывает только иметь возможность прочитать свойство
    }
}
