using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCourses
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Wk06CoursesContext db = new Wk06CoursesContext();
        public MainWindow()
        {
            InitializeComponent();

            cboCourse.ItemsSource = (from c in db.Courses select c).ToList();
            cboInstructor.ItemsSource = (from i in db.Instructors select i).ToList();
        }
    }
}
