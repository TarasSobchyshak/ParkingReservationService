using PRS.Components.Interfaces.ObjectMapper;

namespace PRS.Components.Implementations.ObjectMapper
{
    public class ObjectMapper : IObjectMapper
    {
        public TFrom Map<TTo, TFrom>(TTo value)
        {
            var res = AutoMapper.Mapper.Map<TTo, TFrom>(value);
            return res;
        }
    }
}
