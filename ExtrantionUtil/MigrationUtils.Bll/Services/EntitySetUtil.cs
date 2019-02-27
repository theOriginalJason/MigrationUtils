using System;
using System.Collections.Generic;
using MigrationUtils.Dal.Models;

namespace MigrationUtils.Bll.Services
{
    public static class EntitySetUtil
    {
        public static Dictionary<Type,string> GetEntityDictionary()
        {
            return new Dictionary<Type,string>
            {
                {typeof(ActiveDirectoryUserRole),"SELECT * FROM [dbo].[ActiveDirectoryUserRoles]"},
                {typeof(Broker),"SELECT * FROM [dbo].[Brokers]"},
                {typeof(CriticalMilestoneName),"SELECT * FROM [dbo].[CriticalMilestoneNames]"},
                {typeof(CriticalMilestoneProgression),"SELECT * FROM [dbo].[CriticalMilestoneProgressions]"},
                {typeof(CriticalMilestone),"SELECT * FROM [dbo].[CriticalMilestones]"},
                {typeof(CriticalMilestoneSnap),"SELECT * FROM [dbo].[CriticalMilestoneSnaps]"},
                {typeof(Customer),"SELECT * FROM [dbo].[Customers]"},
                {typeof(CustomerType),"SELECT * FROM [dbo].[CustomerTypes]"},
                {typeof(DateDimension),"SELECT * FROM [dbo].[DateDimension]"},
                {typeof(DepartmentType),"SELECT * FROM [dbo].[DepartmentTypes]"}
            };
        }
    }
}