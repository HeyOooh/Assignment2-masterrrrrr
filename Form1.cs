using Assignment.Enum;
using Assignment_2.AbstractClasses;
using Assignment_2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._0
{

    /// <summary>
    /// 
    /// </summary>
    public partial class GUI : Form
    {

        // The image the user will choose for an estate
        private Bitmap image = null;

        // Handler for the estates, contains a ArrayList for the estates and a HashSet with Ids for quick lookup
        private EstateManager estateManager;


        /// <summary>
        /// Constructor to the components
        /// </summary>
        public GUI()
        {
            InitializeComponent();

            btnSaveChanges.Enabled = false;
            estateManager = new EstateManager(listBox1);
            comboBoxCountry.DataSource = Countries.GetValues(typeof(Countries));
            comboBoxLegalForm.DataSource = LegalForms.GetValues(typeof(LegalForms));
            comboBoxCategory.DataSource = Category.GetValues(typeof(Category));
            comboBoxLegalForm.DataSource = LegalForms.GetValues(typeof(LegalForms));
            comboBox5.DataSource = TypeAll.GetValues(typeof(TypeAll));
            lblDynamicTxt1.Text = "---------";
            btnChangeEstate.BackColor = Color.FromArgb(140, 135, 222);
            btnCreateEstate.BackColor = Color.FromArgb(140, 135, 222);
            btnChooseImage.BackColor = Color.FromArgb(140, 135, 222);
            btnSaveChanges.BackColor = Color.FromArgb(168, 165, 209);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        /*
        /// <summary> BTN CHANGE ESTATE!!!!!
        /// If the the id is in the ids HashSet this method updates the text fields, image and comboboxes with
        /// the values from the estate with that id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            

           // string changeEstatetext = textBoxChangeEstate.Text;
           //  estateManager.UpdateEstatesFields(comboBoxLegalForm, comboBoxCountry, comboBoxCategory, comboBoxType, textBoxChangeEstate, textBoxCity, textBoxZipCode, textBoxStreet, textBox6, changeEstatetext, textId, pictureBoxImage);
            
            if(estateManager.containsId(changeEstatetext))
            {
                comboBox4_SelectedIndexChanged(sender, e);
                
                // Enabling and disabling buttons to hinder the user to press buttons that should not be pressed
                textId.ReadOnly = true;
                btnCreateEstate.Enabled = false;
                btnChangeEstate.Enabled = false;
                btnSaveChanges.Enabled = true;
                btnDeleteAll.Enabled = false;
                btnGenerateEstates.Enabled = false;
                btnSearch.Enabled = false;
                btnShowAll.Enabled = false;
                btnDelete.Enabled = false;

                btnSaveChanges.BackColor = Color.FromArgb(140, 135, 222);
                btnCreateEstate.BackColor = Color.FromArgb(168, 165, 209);
                btnChangeEstate.BackColor = Color.FromArgb(168, 165, 209);
            }
        }

        */


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Method to chooose the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = new Bitmap(openFileDialog.FileName);
                pictureBoxImage.Image = image;
            }
        }


        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// Creates an estate with the given data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEstate_Click(object sender, EventArgs e)
        {

            // Gets all the value from the GUI to create an Estate object
            string id = textId.Text;
            LegalForms legalForm = (LegalForms) comboBoxLegalForm.SelectedItem;
            Countries country = (Countries)comboBoxCountry.SelectedItem;
            string city = textBoxCity.Text;
            string zipCode = textBoxZipCode.Text;
            string street = textBoxStreet.Text;
            Category category = (Category)comboBoxCategory.SelectedItem;
            var type = comboBoxType.SelectedItem;
            string text = textBox6.Text;
            TypeAll typeAll = (TypeAll)comboBoxType.SelectedItem;
            bool isModifyingEstate = false;

           // estateManager.createEstate(id, legalForm, country, city, zipCode, street, category, type, text, image, typeAll, isModifyingEstate);


            // To differentiate if the btn create or change was clicked
            if (isModifyingEstate)
            {
               // Estate oldEstate = estateManager.GetEstate(id);
                //estateManager.Delete(oldEstate, id);
            }

            // Id must be unique and in a valid format and all the fields int the GUI must be filled
            if (!estateManager.isIdValid(id) || !estateManager.uniqueId(id) || !estateManager.allFieldsFilled(city, zipCode, street, text))
            {
                return;
            }

            // Creates an address from the given address data
            Address address = new Address(street, zipCode, city, country);
            Estate estate = null;

            // Creates an estate in the correct type, depending on what type the user has chosen
            switch (type)
            {
                case TypeCom.Shop:
                    estate = new Shop(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeCom.Warehouse:
                    estate = new Warehouse(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeRes.Apartment:
                    estate = new Apartment(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeRes.House:
                    estate = new House(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeRes.Townhouse:
                    estate = new Townhouse(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeRes.Villa:
                    estate = new Villa(id, text, legalForm, image, address, category, typeAll);
                    break;
                default:
                    break;
            }

            // TODO hantera om returnerar false? Wuut
            estateManager.Add(estate);
        }

        
        /// <summary>
        /// Validates that all the information is filled in correctly and then creates an estate object
        /// and puts it into the estates list.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="legalForm"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="street"></param>
        /// <param name="category"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="image"></param>
     /*   public void btnCreateEstate_Click(string id, LegalForms legalForm, Countries country, string city, string zipCode, string street, Category category, object type, string text, Bitmap image, TypeAll typeAll, bool isModifyingEstate)
        {
            if (isModifyingEstate)
            {
                Estate oldEstate = estateManager.GetEstate(id);
                estateManager.Delete(oldEstate, id);
            }

            // || !hasChosenImage(image) ?? Maybe remove??

            if (!estateManager.isIdValid(id) || !estateManager.uniqueId(id) || !estateManager.allFieldsFilled(city, zipCode, street, text))
            {
                return;
            }

            Address address = new Address(street, zipCode, city, country);
            Estate estate = null;

            switch (type)
            {
                case TypeCom.Shop:
                    estate = new Shop(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeCom.Warehouse:
                    estate = new Warehouse(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeRes.Apartment:
                    estate = new Apartment(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeRes.House:
                    estate = new House(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeRes.Townhouse:
                    estate = new Townhouse(id, text, legalForm, image, address, category, typeAll);
                    break;
                case TypeRes.Villa:
                    estate = new Villa(id, text, legalForm, image, address, category, typeAll);
                    break;
                default:
                    break;
            }

            estateManager.Add(estate);
        }

        */


        private void comboBoxLegalForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Helper method to set the type-combobox with the correct Enum values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxCategory.SelectedItem.Equals(Category.Residential))
            {
                comboBoxType.DataSource = TypeRes.GetValues(typeof(TypeRes));
            }
            else
            {
                comboBoxType.DataSource = TypeCom.GetValues(typeof(TypeCom));
            }
        }


        /// <summary>
        /// Helper method to set the label for the unique attribute with the correct string 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxType.SelectedItem)
            {
                case TypeRes.Villa:
                    lblDynamicTxt1.Text = "Lawn size (m2):";
                break;

                case TypeRes.Apartment:
                    lblDynamicTxt1.Text = "Floor number:";
                break;

                case TypeRes.Townhouse:
                    lblDynamicTxt1.Text = "Height(meters):";
                break;

                case TypeRes.House:
                    lblDynamicTxt1.Text = "Color:";
                break;

                case TypeCom.Shop:
                    lblDynamicTxt1.Text = "Type of Shop:";
                break;

                case TypeCom.Warehouse:
                    lblDynamicTxt1.Text = "Capacity (m3):";
                break;

                default:
                    MessageBox.Show("Something went wrong, this type is not in the enum list");
                    break;
            }
        }

        private void lblSearchEstates_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Unique attibute data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// When the delete button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexToDelete = listBox1.SelectedIndex;
            estateManager.DeleteAt(indexToDelete);
        }

        // DeleteAt(int anIndex)

        /*

        /// <summary>
        /// When the search button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            TypeAll typeAll = (TypeAll)comboBox5.SelectedItem;
            string city = textBox9.Text;
            estateManager.SearchEstate(typeAll, city);
        }


        /// <summary>
        /// Shows all the estates in the estates ArrayList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            estateManager.showAllEstates();
       */


        /// <summary>
        /// Deletes all the estates in the estates ArrayList.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            estateManager.DeleteAll();
        }


        /// <summary>
        /// Generates nine estates to make it easier for the user to test the search function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerateEstates_Click(object sender, EventArgs e)
        {
            Estate[] estates = new Estate[9];

            Address address1 = new Address("Street1", "24010", "Lund", Countries.Sverige);
            Address address2 = new Address("Street2", "22224", "Malmö", Countries.Sverige);
            Address address3 = new Address("Street3", "08122", "Ystad", Countries.Sverige);

            estates[0] = new Shop("0001", "Food", LegalForms.Rental, null, address1, Category.Commercial, TypeAll.Shop);
            estates[1] = new Shop("0002", "Paint", LegalForms.Rental, null, address2, Category.Commercial, TypeAll.Shop);
            estates[2] = new Shop("0003", "Pizza", LegalForms.Ownership, null, address3, Category.Commercial, TypeAll.Shop);

            estates[3] = new Warehouse("0004", "1000", LegalForms.Ownership, null, address1, Category.Commercial, TypeAll.Warehouse);
            estates[4] = new Warehouse("0005", "2000", LegalForms.Rental, null, address1, Category.Commercial, TypeAll.Warehouse);
            estates[5] = new Warehouse("0006", "3000", LegalForms.Ownership, null, address2, Category.Commercial, TypeAll.Warehouse);

            estates[6] = new Villa("0007", "100", LegalForms.Rental, null, address2, Category.Residential, TypeAll.Villa);
            estates[7] = new Villa("0008", "200", LegalForms.Ownership, null, address3, Category.Residential, TypeAll.Villa);
            estates[8] = new Villa("0009", "300", LegalForms.Rental, null, address3, Category.Residential, TypeAll.Villa);


            estateManager.genereateEstates(estates);
        }


        /// <summary>
        /// If the user clicks the save changes button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string id = textId.Text;
            LegalForms legalForm = (LegalForms)comboBoxLegalForm.SelectedItem;
            Countries country = (Countries)comboBoxCountry.SelectedItem;
            string city = textBoxCity.Text;
            string zipCode = textBoxZipCode.Text;
            string street = textBoxStreet.Text;
            Category category = (Category)comboBoxCategory.SelectedItem;
            var type = comboBoxType.SelectedItem;
            string text = textBox6.Text;
            TypeAll typeAll = (TypeAll)comboBoxType.SelectedItem;

            bool isModifyingEstate = true;
            estateManager.createEstate(id, legalForm, country, city, zipCode, street, category, type, text, image, typeAll, isModifyingEstate);

            btnSaveChanges.Enabled = false;
            btnChangeEstate.Enabled = true;
            btnCreateEstate.Enabled = true;
            textId.ReadOnly = false;
            btnDeleteAll.Enabled = true;
            btnGenerateEstates.Enabled = true;
            btnSearch.Enabled = true;
            btnShowAll.Enabled = true;
            btnDelete.Enabled = true;

            btnSaveChanges.BackColor = Color.FromArgb(168, 165, 209);
            btnChangeEstate.BackColor = Color.FromArgb(140, 135, 222);
            btnCreateEstate.BackColor = Color.FromArgb(140, 135, 222);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private async void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // char msg = "Id:" + id + "Legalform:" + legalForm + "Country:" + country + "City:" + city + "zipcode:" + zipCode + "Street:" + street + " Category:" + category + "Ttype:" + type + "Text:" + text + "Type:" + typeAll;
            string tmpStr = "";
            foreach(var item in listBox1.SelectedItems)
            {
                tmpStr += listBox1.GetItemText(item.ToString()) + "\n";
            }
            using (SaveFileDialog ofd = new SaveFileDialog() { Filter= "Text files (*.txt)|*.txt|All files (*.*)|*.*", ValidateNames = true})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sr = new StreamWriter(ofd.FileName))
                        {
                            await sr.WriteLineAsync(tmpStr);
                            MessageBox.Show("Successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch(Exception eo)
                    {
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(eo.Message);
                    }
                }
            }
        }

        private void lblDeleteEstates_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeEstate_Click(object sender, EventArgs e)
        {

        }
    }
}