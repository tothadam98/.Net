using EmployeeApp.ViewModel.Base;
namespace EmployeeApp.Model
{
    public class EmployeeDTO : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}