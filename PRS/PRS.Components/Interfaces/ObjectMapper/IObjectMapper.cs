namespace PRS.Components.Interfaces.ObjectMapper
{
    public interface IObjectMapper
    {
        TTo Map<TFrom, TTo>(TFrom value);
    }
}
