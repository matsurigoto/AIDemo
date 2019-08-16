namespace FabrikamFiberLab.Web.ViewModels
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using FabrikamFiberLab.DAL.Models;

    public class EmployeeReportViewModel : Controller
    {
        public IEnumerable<EmployeeSummary> Employees { get; set; }

        public string GetCustomerSummary(Customer customer)
        {
            return string.Format("{0}, {1}", customer.FullName, customer.Address.City);
        }
    }
}
