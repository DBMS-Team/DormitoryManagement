using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public partial class FrmStudent : Form
    {
        private StudentDTO loginStudent;
        private UserDTO loginUser;
        public StudentDTO LoginStudent
        {
            get => loginStudent;
            set
            {
                this.loginStudent = value;
            }
        }
        public UserDTO LoginUser
        {
            get => loginUser;
            set
            {
                this.loginUser = value;
            }
        }
        public FrmStudent(StudentDTO student, UserDTO user)
        {
            InitializeComponent();
        }
    }
}
