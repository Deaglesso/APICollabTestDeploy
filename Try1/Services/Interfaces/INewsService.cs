using Try1.DTOs.News;

namespace Try1.Services.Interfaces
{
    public interface INewsService
    {
        Task<ICollection<GetNewsDTO>> GetAllAsync();
    }
}
