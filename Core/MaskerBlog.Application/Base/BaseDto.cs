namespace MaskerBlog.Application.Base
{
    public abstract class BaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }// Ne zaman Oluşturuldu
        public DateTime UpdatedAt { get; set; }// Ne zaman Güncellendi
    }
}
