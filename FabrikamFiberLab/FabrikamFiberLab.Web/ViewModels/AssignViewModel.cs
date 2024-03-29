﻿namespace FabrikamFiberLab.Web.ViewModels
{
    using System.Collections.Generic;

    using FabrikamFiberLab.DAL.Models;
    
    public class AssignViewModel
    {
        public ServiceTicket ServiceTicket { get; set; }

        public IEnumerable<Employee> AvailableEmployees { get; set; }

        public IEnumerable<ScheduleItem> ScheduleItems { get; set; }
    }
}