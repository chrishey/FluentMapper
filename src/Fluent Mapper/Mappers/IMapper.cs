namespace Fluent_Mapper.Mappers
{
    public interface IMapper<out T, in TY> where T: class
    {
        T MapLite(TY entity);
        T MapFull(TY entity);
    }
}
