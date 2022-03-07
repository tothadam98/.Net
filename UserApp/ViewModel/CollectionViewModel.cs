using System.Collections.ObjectModel;
using UserApp.Model;


namespace UserApp.ViewModel
{
    public class CollectionViewModel
    {
        //public List<User> Users { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Name = "Administrator" });
            Users.Add(new User() { Name = "root" });
            Users.Add(new User() { Name = "Blackhawk" });
            Users.Add(new User() { Name = "User001" });
            Users.Add(new User() { Name = "Cortana" });
        }
    }
}
