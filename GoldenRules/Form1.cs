using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRules
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            radioButton1.Checked = true;
            textBox1.Font = new Font("Arial", 12, FontStyle.Bold);
            if (radioButton1.Checked == true)
            {
                comboBox1.Text = "Description";
            }
           
            

            comboBox1.Font = new Font("Arial", 9, FontStyle.Bold);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        

            if (comboBox1.SelectedIndex == 0)
            {

                textBox1.Text = "Consistent sequences of actions should be required in similar situations; identical terminology should be used in prompts, menus, and help screens; and consistent color, layout, capitalization, fonts, and so on should be employed throughout. Exceptions, such as required confirmation of the delete command or no echoing of passwords, should be comprehensible and limited in number.";
                textBox1.BackColor = Color.Aqua;
                
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "Recognize the needs of diverse users and design for plasticity, facilitating transformation of content. Novice to expert differences, age ranges, disabilities, and technological diversity each enrich the spectrum of requirements that guides design. Adding features for novices, such as explanations, and features for experts, such as shortcuts and faster pacing, can enrich the interface design and improve perceived system quality.";
                textBox1.BackColor = Color.Azure;
               
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "For every user action, there should be system feedback. For frequent and minor actions, the response can be modest, whereas for infrequent and major actions, the response should be more substantial. Visual presentation of the objects of interest provides a convenient environment for showing changes explicitly.";
                textBox1.BackColor = Color.WhiteSmoke;
                

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = "Sequences of actions should be organized into groups with a beginning, middle, and end. Informative feedback at the completion of a group of actions gives operators the satisfaction of accomplishment, a sense of relief, a signal to drop contingency plans from their minds, and an indicator to prepare for the next group of actions. For example, e-commerce web sites move users from selecting products to the checkout, ending with a clear confirmation page that completes the transaction.";
                textBox1.BackColor = Color.DarkKhaki;
            }
            else if (comboBox1.SelectedIndex == 4) {
                textBox1.Text = "As much as possible, design the system such that users cannot make serious errors; for example, gray out menu items that are not appropriate and do not allow alphabetic characters in numeric entry fields. If a user makes an error, the interface should detect the error and offer simple, constructive, and specific instructions for recovery. For example, users should not have to retype an entire name-address form if they enter an invalid zip code, but rather should be guided to repair only the faulty part. Erroneous actions should leave the system state unchanged, or the interface should give instructions about restoring the state.";
                textBox1.BackColor = Color.GreenYellow;
            }

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "These principles, derived from experience and refined over three decades, require validation and tuning for specific design domains. No list such as this can be complete, but it has been well received as a useful guide to students and designers";
        }


    }
}
