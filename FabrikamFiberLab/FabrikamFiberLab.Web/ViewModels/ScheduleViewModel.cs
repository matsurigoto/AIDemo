namespace FabrikamFiberLab.Web.ViewModels
{
    using System.Linq;

    using FabrikamFiberLab.DAL.Models;

    public class ScheduleViewModel
    {
        public ServiceTicket ServiceTicket { get; set; }

        public Employee Employee { get; set; }

        public IQueryable<ScheduleItem> ScheduleItems { get; set; }
    }
}