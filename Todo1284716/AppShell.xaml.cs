using Todo1284716.Views;
namespace Todo1284716
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));

        }
    }
}
