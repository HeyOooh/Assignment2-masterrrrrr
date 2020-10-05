﻿using Assignment.Enum;
using Assignment.Interface;
using Assignment_2.AbstractClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2.Classes
{

    /// <summary>
    /// Class to handle all the logic for the program, contains an ArrayList of estates, a HashSet of ids and methods to manipulate these datastructures.
    /// <author> Agnes Hägnestrand and Andreas Holm</author>
    /// </summary>
    class ListManager<T> : IListManager<T>
    {

        private List<T> m_list;

        private int count;
        // private String[] toStringArray;
        // private List<string> toStringList;


        // To handle all the estates
        private ArrayList estates = new ArrayList();

        // A set to make sure all the ids are unique
        private HashSet<string> ids = new HashSet<string>();

        // The RichTextBox component in the GUI
        private ListBox listBox1;


        public ListManager()
        {
            m_list = new List<T>();
        }

        /// <summary>
        /// Constructor to set up the component RichTextBox
        /// </summary>
        /// <param name="richTxtBx"></param>
        public ListManager(ListBox listBox1)
        {
            this.listBox1 = listBox1;
            m_list = new List<T>();
        }


        public int Count
        {
            get { return count; }
            set { count = value; }
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
        public void createEstate(string id, LegalForms legalForm, Countries country, string city, string zipCode, string street, Category category, object type, string text, Bitmap image, TypeAll typeAll, bool isModifyingEstate)
        {
            if (isModifyingEstate)
            {
                Estate oldEstate = GetEstate(id);
                estates.Remove(oldEstate);
                ids.Remove(id);
            }

            // || !hasChosenImage(image) ?? Maybe remove??

            if (!isIdValid(id) || !uniqueId(id) || !allFieldsFilled(city, zipCode, street, text))
            {
                return;
            }

            Address address = new Address(street, zipCode, city, country);

            switch (type)
            {

                case TypeCom.Shop:
                    Shop shop = new Shop(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(shop);
                    ids.Add(id);
                    break;
                case TypeCom.Warehouse:
                    Estate warehouse = new Warehouse(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(warehouse);
                    ids.Add(id);
                    break;
                case TypeRes.Apartment:
                    Estate apartment = new Apartment(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(apartment);
                    ids.Add(id);
                    break;
                case TypeRes.House:
                    Estate house = new House(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(house);
                    ids.Add(id);
                    break;
                case TypeRes.Townhouse:
                    Estate townhouse = new Townhouse(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(townhouse);
                    ids.Add(id);
                    break;
                case TypeRes.Villa:
                    Estate villa = new Villa(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(villa);
                    ids.Add(id);
                    break;
                default:
                    break;
            }

            updateTxtWindow();
        }


        /// <summary>
        /// Helper method to fill the estates with 10 estate object to make it easier for the user to test the search
        /// Removes the previously estates in the estates ArrayList
        /// </summary>
        public void genereateEstates(T[] estates)
        {
            DeleteAll();

            for(int i = 0; i < estates.Length; i ++)
            {
                m_list.Add(estates[i]);
            }

            updateTxtWindow();
        }


        /// <summary>
        /// Shows all the estates in the estates list
        /// </summary>
        public void showAllEstates()
        {
            updateTxtWindow();
        }


        /// <summary>
        /// Checks if the user has filled in all the fields
        /// </summary>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="street"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool allFieldsFilled(string city, string zipCode, string street, string text)
        {
            if (city.Equals("") || zipCode.Equals("") || street.Equals("") || text.Equals(""))
            {
                MessageBox.Show("Please fill in all the fields");
                return false;
            }

            return true;
        }



        /// <summary>
        /// Checks if the user has chosen an image
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private bool hasChosenImage(Bitmap image)
        {
            if (image == null)
            {
                MessageBox.Show("Please choose a picture");
                return false;
            }

            return true;
        }


        /// <summary>
        /// Checks if the given id is unique
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool uniqueId(string id)
        {
            if (ids.Contains(id))
            {
                MessageBox.Show("The Id is already in our register, please choose an unique Id, to se all the Ids browse to the Search/Delete tab");
            }

            return !ids.Contains(id);
        }



        /// <summary>
        /// Checks if the given id is in the ids HashSet
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool containsId(string id)
        {
            return ids.Contains(id);
        }



        /// <summary>
        /// Validate that the Id follows the preapproved format, four numbers
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool isIdValid(string id)
        {
            int correctIdLenght = 4;
            if (id.Length != correctIdLenght)
            {
                MessageBox.Show("The Id you chose is not a valid Id, it should consist of four numbers, eg 1234");
                return false;
            }

            if (!id.All(char.IsDigit))
            {
                MessageBox.Show("The id must consist of all numbers!");
                return false;
            }

            return true;
        }



   



        /// <summary>
        /// Deletes the Estate object with the given id, if the Estate is not present, 
        /// return null and print out a message to the user.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteEstate(string id)
        {

            // Check to se if the given id is present in the ids set
            if (!ids.Contains(id))
            {
                MessageBox.Show($"There is no Estate object in the hashSet that has the id {id}");
                return;
            }

            // Removes the estate with the given id
            foreach (Estate e in estates)
            {
                if (e.Id == id)
                {
                    estates.Remove(e);
                    ids.Remove(id);
                    updateTxtWindow();
                    MessageBox.Show($"Estate with the id {id} was successfully deleted");
                    return;
                }
            }
        }

        // Kolla igenom alla estates och ändra till m_list :) 

        //__________________________________________________________________________
        //HAR TAGIT BORT ID SOM PARAMETER FÖR DELETE SKA ENDAST HA OBJECT FÖR GENERICS
        //__________________________________________________________________________
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        public void Delete(T type)
        {
            estates.Remove(type);

            // ids.Remove(id);
        }


        /// <summary>
        /// Updates the list of estates is the RichTextBox window in the Search/Delete tab
        /// </summary>
        public void updateTxtWindow()
        {
            listBox1.Items.Clear();
            string estatesList = "";

            foreach (T e in m_list)
            {
                //estatesList += e.ToString() + "\n";
                listBox1.Items.Add(e.ToString() + "\n");
            }

            listBox1.Items.Add(estatesList);
        }


        /// <summary>
        /// Save to a file
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
        /// <param name="typeAll"></param>
        public void SaveFile(string id, LegalForms legalForm, Countries country, string city, string zipCode, string street, Category category, object type, string text, TypeAll typeAll)
        {
            String msg = "Id:" + id + "Legalform:" + legalForm + "Country:" + country + "City:" + city + "zipcode:" + zipCode + "Street:" + street + " Category:" + category + "Ttype:" + type + "Text:" + text + "Type:" + typeAll;
            String txt = "\file.txt";

            //   using (StringReader reader = new StringReader(msg.ToString())
            // {
            // string readText = await reader.ReadToEndAsync
            //   }
            //  FileStream fileStream = new FileStream(txt, FileMode.Create, FileAccess.Write);
            // StreamWriter streamWriter = new StreamWriter(fileStream);
            // streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            // streamWriter.Write(msg);
            // streamWriter.Flush();
            // streamWriter.Close();
        }



        /// <summary>
        /// Helper method to get the Estate with the given id, if the Estate is not present, 
        /// return null and print out a message to the user.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Estate GetEstate(string id)
        {

            // Check to se if the given id is present in the ids set
            if (!ids.Contains(id))
            {
                MessageBox.Show($"There is no Estate object in the hashSet that has the id {id}");
                return null;
            }

            foreach (Estate e in estates)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }

            return null;
        }


        /*
        /// <summary>
        /// Sets the string in RichTextBox component to all the Estates that has the searched type and city
        /// </summary>
        /// <param name="type"></param>
        /// <param name="city"></param>
        /// <returns></returns>

        public void SearchEstate(TypeAll type, string city)
        {
            string estatesList = "";
            foreach (T e in m_list)
            {
                if (e.TypeAll.Equals(type) && e.Address.City.Equals(city))
                {
                    estatesList += e.ToString() + "\n";

                }
            }

            listBox1.Items.Add(estatesList);
        }

        */



        /// <summary>
        /// Updates the text fields when the user presses CHANGE ESTATE from the given id
        /// </summary>
        /// <param name="comboBoxLegalForm"></param>
        /// <param name="comboBoxCountry"></param>
        /// <param name="comboBoxCategory"></param>
        /// <param name="comboBoxType"></param>
        /// <param name="textchange"></param>
        /// <param name="textcity"></param>
        /// <param name="textzip"></param>
        /// <param name="textStreet"></param>
        /// <param name="textUnique"></param>
        /// <param name="changeText"></param>
        /// <param name="textId"></param>
        /// <param name="pictureBoxImage"></param>
        public void UpdateEstatesFields(ComboBox comboBoxLegalForm, ComboBox comboBoxCountry, ComboBox comboBoxCategory, ComboBox comboBoxType, TextBox textchange, TextBox textcity, TextBox textzip, TextBox textStreet, TextBox textUnique, string changeText, TextBox textId, PictureBox pictureBoxImage)
        {

            if (!ids.Contains(changeText))
            {
                MessageBox.Show($"There is no Estate object in the hashSet that has the id {changeText}");
                return;

            }
            else
            {
                foreach (Estate e in estates)
                {
                    if (e.Id == changeText)
                    {

                        textId.Text = changeText;
                        comboBoxLegalForm.SelectedItem = e.LegalForm;
                        comboBoxCountry.SelectedItem = e.Address.Country;
                        textcity.Text = e.Address.City.ToString();
                        textzip.Text = e.Address.ZIPCode.ToString();
                        textStreet.Text = e.Address.Street.ToString();

                        comboBoxCategory.SelectedItem = e.Category;
                        comboBoxType.SelectedItem = e.getType();


                        textUnique.Text = e.UniqueAttribute;

                        if (e.Image != null)
                        {
                            pictureBoxImage.Image = e.Image;
                        }

                        return;
                    }
                }
            }
        }

        // ALLA DESSA 

        /// <summary>
        /// Adds an estate to the List and updates the ListBox
        /// TODO add false return???
        /// </summary>
        /// <param name="aType"></param>
        /// <returns></returns>
        public bool Add(T aType)
        { 
            m_list.Add(aType);
            updateTxtWindow();
            return true;
        }

        public bool BinaryDeSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool BinarySerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            throw new NotImplementedException();
        }

        public bool CheckIndex(int index)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Deletes all the objects in the m_list and updates the ListBox with the empty list
        /// </summary>
        public void DeleteAll()
        {
            m_list.Clear();
            updateTxtWindow();
        }


        /// <summary>
        /// Removes an object from the m_list at a given index and updates the ListBox
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public bool DeleteAt(int anIndex)
        {
            MessageBox.Show(anIndex.ToString());
            m_list.RemoveAt(anIndex);
            updateTxtWindow();
            return true;
        }


        /// <summary>
        /// Returns the element form the m_list at the given index
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public T GetAt(int anIndex)
        {
            return m_list.ElementAt(anIndex);
        }

        public string[] ToStringArray()
        {

            throw new NotImplementedException();
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

    }
}
