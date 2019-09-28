using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PhoneBookDemo.MultiTenancy.HostDashboard.Dto;

namespace PhoneBookDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}