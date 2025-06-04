using MasterPolApp.Model;
using System.Windows.Controls;

namespace MasterPolApp.Core
{
    /// <summary>
    /// Главный класс навигации, содержит поля навигации и базы данных
    /// </summary>
    public static class MyService
    {
        public static Frame MainNavigationFrameApp { get; set; }
        public static MasterPoldbEntities1 DB { get; set; }
    }
}
