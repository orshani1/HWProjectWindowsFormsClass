using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackermeDB;

namespace HWProjectWindowsFormsClass
{
    public partial class searchByLastNameDeleteButton : Form
    {
        public event EventHandler enabledChanged;
        public searchByLastNameDeleteButton()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void searchByLastNameSaveButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.IsLessThanNine() == true)
            {
                string title = "Invaild Id";
                MessageBox.Show("ERROR : ID Less Than 9", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (IdTextBox.IsNotNumber() == true)
            {
                string title = "Invaild Id";
                MessageBox.Show("ERROR : ID Needs To Be A Number !!!");
            }
            if (textBox2.IsNotRealName() == true)
            {
                string title = "Invaild name";
                MessageBox.Show("ERROR : Please Enter Real Name",title, MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                                                                                                  
            }                                                                                     
            if (textBox3.IsNotRealName() == true)                                                 
            {                                                                                     
                string title = "Invaild name";                                                    
                MessageBox.Show("ERROR : Please Enter Real Name",title, MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            if (textBox4.IsNotNumber() == true || textBox4.IsLessThanTen() == true)
            {
                string title = "Phone Number Error";
                MessageBox.Show("ERROR :invaild Phone Number",title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            for (int i = 0; i < EmailAdressTextBox.Text.Length; i++)
            {
                    string title = "Invail Email";
                if (EmailAdressTextBox.Text[i] == '$' || EmailAdressTextBox.Text[i] == '%' || char.IsSymbol(EmailAdressTextBox.Text[i]) == true)
                    MessageBox.Show("ERROR :invaild Email",title, MessageBoxButtons.OKCancel,MessageBoxIcon.Error);

            }
            if (EmailAdressTextBox.TextLength < 3)
            {
                string title = "Invail Email";
                MessageBox.Show("ERROR :Email Too Short",title,MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {


                var student = new HackermeDB.DB.Students();
                student.firstName = textBox2.Text;
                student.lastName = textBox3.Text;
                student.phoneNumber = textBox4.Text;
                student.studentID = IdTextBox.Text;
                student.DOB = dateTimePicker1.Value;
                student.cityID = listBox1.Text;
                student.EmailAdress = EmailAdressTextBox.Text;


                

                HackermeDB.DB.MyDB.studentsList.Add(student);




                MessageBox.Show("New student was added succsesfully");
                HackermeDB.DB.MyDB.Count++;
                textBox2.Clear();
                IdTextBox.Clear();
                textBox3.Clear();
                textBox4.Clear();
                EmailAdressTextBox.Clear();

            }
        }






        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchByLastNameSearchButton_Click(object sender, EventArgs e)
        {
    
            if (SearchByLastNameTextBox.IsNotRealName() == true)
            {
                MessageBox.Show("Please Enter Real Name");
            }

            else
            {
                if (HackermeDB.DB.MyDB.studentsList.Count == 0)
                {

                    string title1 = "No Student Found";
                    string message = "Error : \nThe list of Students is Empty";
                    MessageBoxButtons msgIcon = MessageBoxButtons.RetryCancel;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show(message, title1, msgIcon,icon);
                }
                for (int i = 0; i < HackermeDB.DB.MyDB.studentsList.Count; i++)
                {
                    if (HackermeDB.DB.MyDB.studentsList[i].lastName == SearchByLastNameTextBox.Text)
                    {
                        textBox2.Text = HackermeDB.DB.MyDB.studentsList[i].firstName;
                        textBox3.Text = HackermeDB.DB.MyDB.studentsList[i].lastName;
                        textBox4.Text = HackermeDB.DB.MyDB.studentsList[i].phoneNumber;
                        IdTextBox.Text = HackermeDB.DB.MyDB.studentsList[i].studentID;
                        EmailAdressTextBox.Text = HackermeDB.DB.MyDB.studentsList[i].EmailAdress;
                       
                  
                    }
                   

                }
                   


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return this.Text;
        }

        private void SearchByLastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            IdTextBox.Clear();
            EmailAdressTextBox.Clear();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string title = "Delete Student";
            
           DialogResult diag = MessageBox.Show("Are You Sure You Want To Delete This Student?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(diag == DialogResult.Yes)
            {
                for (int i = 0; i < HackermeDB.DB.MyDB.studentsList.Count; i++)
                {
                    if(HackermeDB.DB.MyDB.studentsList[i].studentID == IdTextBox.Text)
                    {
                        HackermeDB.DB.MyDB.studentsList.Remove(HackermeDB.DB.MyDB.studentsList[i]);
                        MessageBox.Show("Student got deleted!");
                        ClearAllTextBox();
                    }
                    else
                    {
                        string title1 = "No Student Found";
                        string message = "Error : \nNo Student Found";
                        MessageBoxButtons msgIcon = MessageBoxButtons.RetryCancel;
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBox.Show(message,title1,msgIcon,icon);
                    }
                }
              
                
            }
            else
            {
                 
            }
        }

        private void searchByLastNameDeleteButton_Load(object sender, EventArgs e)
        {
     
        }
        private void ClearAllTextBox()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            IdTextBox.Clear();
            EmailAdressTextBox.Clear();
        }

        private void NetBasicTextBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.IsLessThanNine() == true)
            {
                string title = "Invaild Id";
                MessageBox.Show("ERROR : ID Less Than 9", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (IdTextBox.IsNotNumber() == true)
            {
                string title = "Invaild Id";
                MessageBox.Show("ERROR : ID Needs To Be A Number !!!");
            }
            if (textBox2.IsNotRealName() == true)
            {
                string title = "Invaild name";
                MessageBox.Show("ERROR : Please Enter Real Name", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            if (textBox3.IsNotRealName() == true)
            {
                string title = "Invaild name";
                MessageBox.Show("ERROR : Please Enter Real Name", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (textBox4.IsNotNumber() == true || textBox4.IsLessThanTen() == true)
            {
                string title = "Phone Number Error";
                MessageBox.Show("ERROR :invaild Phone Number", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            for (int i = 0; i < EmailAdressTextBox.Text.Length; i++)
            {
                string title = "Invail Email";
                if (EmailAdressTextBox.Text[i] == '$' || EmailAdressTextBox.Text[i] == '%' || char.IsSymbol(EmailAdressTextBox.Text[i]) == true)
                    MessageBox.Show("ERROR :invaild Email", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            if (EmailAdressTextBox.TextLength < 3)
            {
                string title = "Invail Email";
                MessageBox.Show("ERROR :Email Too Short", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {

                for (int i = 0; i < HackermeDB.DB.MyDB.studentsList.Count; i++)
                {
                    if(IdTextBox.Text == HackermeDB.DB.MyDB.studentsList[i].studentID)
                    {
                        HackermeDB.DB.MyDB.studentsList[i].firstName = textBox2.Text;
                        HackermeDB.DB.MyDB.studentsList[i].lastName = textBox3.Text;
                        HackermeDB.DB.MyDB.studentsList[i].phoneNumber = textBox4.Text;
                        HackermeDB.DB.MyDB.studentsList[i].studentID = IdTextBox.Text;
                        HackermeDB.DB.MyDB.studentsList[i].EmailAdress = EmailAdressTextBox.Text;
                        HackermeDB.DB.MyDB.studentsList[i].DOB = dateTimePicker1.Value;
                        HackermeDB.DB.MyDB.studentsList[i].cityID = listBox1.Text;
                        MessageBox.Show("Changes Has Been Set!", "Change Student Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HackermeDB.DB.MyDB.Count++;
                        textBox2.Clear();
                        IdTextBox.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        EmailAdressTextBox.Clear();

                    }
                }




     

            }

        }

        private void searchByLastNameDeleteButton_Activated(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && IdTextBox.Text.Length > 0)
            {
                button4.Enabled = true;
                button4.Refresh();
            }
        }
    }

}
