using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MouseEvent.DOMAIN.Models;
using MouseEvent.Infrastructure;
using MouseEvent.Infrastructure.Context;
using MouseEvent.IService;

namespace MouseEvent.Service
{
    public class MouseService : IMouseService
    {
        private ApplicationContext db;
        public MouseService(ApplicationContext db) => this.db = db;

        public async Task SaveToJson(MouseDataItemModel mousData)
        {
            try
            {
                MouseData mouseData = new()
                {
                    MouseDataItem = JsonSerializer.Serialize(mousData)
                };
                db.MouseData.Add(mouseData);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
