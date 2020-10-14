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

            for (int i = 0; i < estates.Length; i++)
            {
                Add(estates[i]);
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
        /// Adds an item to the List and updates the ListBox
        /// TODO add false return???
        /// </summary>
        /// <param name="aType"></param>
        /// <returns></returns>
        public bool Add(T aType)
        {
            m_list.Add(aType);
            AddToDictionary(aType);
            updateTxtWindow();
            return true;
        }

        /// <summary>
        /// Method to binary serialize the m_list and save to a given filepath
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool BinaryDeSerialize(string fileName)
        {
            bool Ok = true;
            FileStream fileObj = File.OpenRead(fileName);

            try
            {
                BinaryFormatter binfor = new BinaryFormatter();
                m_list = (List<T>)binfor.Deserialize(fileObj);
                updateTxtWindow();

            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
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
                fileObj = File.Create(fileName);
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(fileObj, m_list);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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

            Person person = new Person("Andreas", "Holm");
            bool bok = true;


            XmlSerializer serializer = new XmlSerializer(typeof(List<Estate>));
            TextWriter writer = new StreamWriter(fileName);
            try
            {
                serializer.Serialize(writer, person);
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

            MessageBox.Show(bok + "");
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
            if (index >= 0 && index < m_list.Count) return true;
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
            if (anIndex != -1)
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
            if(anIndex != -1 && anIndex < m_list.Count)
            {
                return m_list.ElementAt(anIndex);
            }else
            {
                return default(T);
            }
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

            foreach (T type in m_list)
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


        /*
         4.1    Use  a  Dictionary  collection  in  any  part  of  your  application  to  
        handle  some  data  as a [key, value] pair wherever you find it applicable.  

        You can for example let your Manager class provide a list of [EstateCategory, 
        ListOfEstateObjects].  The categories can be any group of objects, e.g. 
        [“Malmö”, All EstateObjects]. 4.2    With the Dictionary type, consider the following: 4.2.1    
        Validate the Key whenever it is used as a method parameter. 
        4.2.2    Write methods to Add, Change, Delete, and Get an item in the collection.
         */

        public void AddToDictionary(T type)
        {
            
            // Om nyckel redan finns lägg till i listan med den nycket
            // ANNARS skapa en nyckel med den staden och lägg till type sist i den listan
        }

        public void ChangeAtDictionary(int index, T type)
        {
            // oklart vad denna ska göra
        }

        public void DeleteFromDictionary(T type)
        {
            // ta bort type från dick med rätt city, om listan är tom, ta bort key helt från dick
        }

        public List<T> GetFromDictionary(string key)
        {
            // validate the key first to se if it exists in the dick
            // returnera hela listan med den givna key 
            return null;
        }


    }

    [Serializable]
    public class Person
    {
        private string m_firstName;
        private string m_lastName;

        /// <remarks>m_errMessage is not to be serialzed.</remarks>
        [NonSerialized]
        private string m_errMessage = null;

        public Person()
        {
        }
        /// <summary>
        /// Consttructor with initial values for first and last names
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <remarks></remarks>
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Property
        /// </summary>
        /// <value>Property related to m_firstName</value>
        /// <returns>The value saved in m_firstName</returns>
        /// <remarks>The value is a string with a new value for m_firstName</remarks>
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }

        /// <summary>
        /// Property
        /// </summary>
        /// <value>Property related to m_lastName</value>
        /// <returns>The value saved in m_lastName</returns>
        /// <remarks>The value is a string with a new value for m_lastName</remarks>
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }

        /// <summary>
        /// Returns the full name, putting together first and last name separated
        /// by a space.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string FullName
        {
            get
            {
                if ((string.IsNullOrEmpty(m_firstName) & string.IsNullOrEmpty(m_lastName)))
                {
                    return "The Invisible Person";
                }

                return FirstName + " " + LastName;
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}