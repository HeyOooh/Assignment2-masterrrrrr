using Assignment_2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._0.Classes
{


    /// <summary>
    /// Class to handle the dictionary
    /// </summary>
    class DictionaryHandler
    {

        // Dictionary with key value pair to help implement a search function
        private Dictionary<string, List<Estate>> dictionary = new Dictionary<string, List<Estate>>();


        /// <summary>
        /// Add the given value to the Dictionary
        /// </summary>
        /// <param name="type"></param>
        public void Add(Estate e)
        {
            string key = e.Address.City;
            if(!dictionary.ContainsKey(key))
            {
                List<Estate> list = new List<Estate>();
                list.Add(e);
                dictionary.Add(key, list);
            }
            else
            {
                List<Estate> list = GetList(key);
                list.Add(e);
            }
        }


       /// <summary>
       /// NOT REALLY SURE WHAT TO DO WITH THIS ONE HELP? ;(
       /// </summary>
       /// <param name="index"></param>
       /// <param name="estate"></param>
        private void ChangeAt(int index, Estate estate)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete the given value from the Dictionary
        /// </summary>
        /// <param name="estate"></param>
        public void Delete(Estate estate)
        {

            // FIX THE NULLPOINTER
            if(estate == null)
            {
                MessageBox.Show("NULLPOINTER");
            }

            string key = estate.Address.City;
            List<Estate> list = GetList(key);
            list.Remove(estate);

            // If after deletion the list at the current key is empty, remove the key
            if(list.Count == 0)
            {
                dictionary.Remove(key);
            }
        }


        /// <summary>
        /// If the key exists in the Dictionary this method returns the list of values of the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<Estate> GetList(string key)
        {
            // Key validation check
            if(dictionary.ContainsKey(key)) return dictionary[key];

            MessageBox.Show($"ERROR: The key: {key} do not exist in the dictionary");
            return null;
        }


        /// <summary>
        /// Clears the Dictionary
        /// </summary>
        public void ClearAll()
        {
            MessageBox.Show(dictionary.Count + "");
            dictionary.Clear();
        }
    }
}
