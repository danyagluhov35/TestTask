using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MouseEvent.DOMAIN.Models;
using MouseEvent.Infrastructure.Context;
using MouseEvent.IService;
using MouseEvent.Service;
using Xunit;

namespace Tests
{
    public class MouseServiceTest
    {
        [Fact]
        public async Task SaveToJsonTest()
        {
            using var dbContext = new ApplicationContext();
            var service = new MouseService(dbContext);

            var mouseDataItemModelTest = new MouseDataItemModel()
            {
                MouseDataModels = new List<MouseDataModel>()
                {
                    new MouseDataModel(){ xData = 1, yData = 10 },
                    new MouseDataModel(){ xData = 2, yData = 11 },
                    new MouseDataModel(){ xData = 3, yData = 12 },
                    new MouseDataModel(){ xData = 4, yData = 13 },
                    new MouseDataModel(){ xData = 5, yData = 14 },
                    new MouseDataModel(){ xData = 6, yData = 15 }
                }
            };

            await service.SaveToJson(mouseDataItemModelTest);

            var savedData = await dbContext.MouseData.FirstOrDefaultAsync();
            Assert.NotNull(savedData);

        }
    }
}
