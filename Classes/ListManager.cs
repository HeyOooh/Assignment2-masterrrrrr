using Assignment.Enum;
using Assignment.Interface;
using Assignment_2.AbstractClasses;
using Assignment_2.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assignment_2.Classes
{

    /// <summary>
    /// Class to handle all the logic for the program, contains an List of type T, and methods to manipulate the list
    /// <author> Agnes Hägnestrand and Andreas Holm</author>
    /// </summary>
    class ListManager<T> : IListManager<T>
    {
        private List<T> m_list;
        private int count;

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


        // Is this to keep track of the length of the list?
        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        /// <summary>
        ///  ---NOT VERY GENERIC BUT KEPT IT TO FACILITATE TESTING---
        /// Helper method to fill the lists with 9 estate object to make it easier for the user to test the search
        /// Removes the previously items in the List
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
        /// Removes the given item from the list
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        public void Delete(T type)
        {
            m_list.Remove(type);
            
            //ids.Remove(id);
        }


        /// <summary>
        /// Updates the list of items in the ListBox window in the Delete tab
        /// </summary>
        public void updateTxtWindow()
        {
            listBox1.Items.Clear();
            string str = "";

            foreach (T e in m_list)
            {
                listBox1.Items.Add(e.ToString() + "\n");
            }

            listBox1.Items.Add(str);
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

        }




        /// <summary>
        /// Adds an item to the List and updates the ListBox
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

        // Agnes har fixat
        public bool BinaryDeSerialize(string fileName)
        {
            bool Ok = true;
            FileStream fileObj = File.OpenRead(fileName);
            try
            {
                BinaryFormatter binfor = new BinaryFormatter();
                m_list = (List<T>)binfor.Deserialize(fileObj);
                listBox1.Text = m_list.ToString();
            }
            catch (Exception e)
            {
            }

            finally
            {
                fileObj.Close();
            }

            return Ok;
        }
    


        /// <summary>
        /// Binary serializes the list and sends it to the given filename
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool BinarySerialize(string fileName)
        {
            bool bOK = true;
            FileStream fileObj = null;
            try
            {
                fileObj = new FileStream(fileName, FileMode.Create);
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(fileObj, m_list);
            }
            catch
            {
                bOK = false;
            }

            finally
            {
                if (fileObj != null)
                    fileObj.Close();
            }
            return bOK;
        }

        /// <summary>
        /// XML-serializes the list and sends it to the given filename
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool XMLSerialize(string fileName)
        {
            bool bok = true;
            //foreach (T e in m_list)
            //    { e.
            //    }
            //    object ob = 

            XmlSerializer serializer = new XmlSerializer(typeof(Estate));
            TextWriter writer = new StreamWriter(fileName);
            try
            {
                serializer.Serialize(writer, m_list);
            }
            catch
            {
                bok = false;
            }
            finally
            {
                if (writer != null)

                    writer.Close();
            }

            return bok;
        }





        // Ska användas vid change estate?
        public bool ChangeAt(T aType, int anIndex)
        {
            m_list[anIndex] = aType;
            return true;
        }


        /// <summary>
        /// Checks if the given index is within the range of the list m_list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            if (m_list.Count == 0) return false;
            if(index >= 0 && index < m_list.Count) return true;
            else return false;
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
            if(anIndex != -1)
            {
                m_list.RemoveAt(anIndex);
                updateTxtWindow();
                return true;
            }

            MessageBox.Show("Please choose an item in the ListBox to remove");
            return false;
        }


        /// <summary>
        /// Returns the element form the m_list at the given index
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public T GetAt(int anIndex)
        {
            // Här krashar det om man väljer det item som ligger under den nedersta ;/ 
            return m_list.ElementAt(anIndex);
        }


        /// <summary>
        /// Resturns a string[] representation of the m_list
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            string[] stringArr = new string[m_list.Count];

            for (int i = 0; i < Count; i++) 
            {
                stringArr[i] = m_list[i].ToString();
            }

            return stringArr;
        }


        /// <summary>
        /// Returns a List<string> representation of the m_list
        /// </summary>
        /// <returns></returns>
        public List<string> ToStringList()
        {
            List<string> list = new List<string>();

            foreach(T type in m_list)
            {
                list.Add(type.ToString());
            }

            return list;
        }


        /// <summary>
        /// Clears all the fields
        /// </summary>
        /// <param name="comboBoxLegalForm"></param>
        /// <param name="comboBoxCountry"></param>
        /// <param name="comboBoxCategory"></param>
        /// <param name="comboBoxType"></param>
        /// <param name="textcity"></param>
        /// <param name="textzip"></param>
        /// <param name="textStreet"></param>
        /// <param name="textUnique"></param>
        /// <param name="textId"></param>
        /// <param name="pictureBoxImage"></param>
        public void ClearFields(ComboBox comboBoxLegalForm, ComboBox comboBoxCountry, ComboBox comboBoxCategory, ComboBox comboBoxType, TextBox textcity, TextBox textzip, TextBox textStreet, TextBox textUnique, TextBox textId, PictureBox pictureBoxImage)
        {
            comboBoxLegalForm.Text = "";
            comboBoxCountry.Text = "";
            comboBoxCategory.Text = "";
            comboBoxType.Text = "";
            textcity.Text = "";
            textId.Text = "";
            textStreet.Text = "";
            textUnique.Text = "";
            textzip.Text = "";
            pictureBoxImage.Image = null;
        }
    }
}
