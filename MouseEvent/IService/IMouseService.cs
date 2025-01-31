using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MouseEvent.DOMAIN.Models;

namespace MouseEvent.IService
{
    public interface IMouseService
    {
        Task SaveToJson(MouseDataItemModel mousData);
    }
}
