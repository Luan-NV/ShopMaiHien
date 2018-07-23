using ShopMaiHien.Data.Enums;

namespace ShopMaiHien.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}