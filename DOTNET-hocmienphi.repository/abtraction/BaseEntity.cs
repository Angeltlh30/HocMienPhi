namespace DOTNET_hocmienphi.repository.abtraction
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; } // kieu chi co DotNET có: Guid
        public bool IsDeleted { get; set; }
    }
}