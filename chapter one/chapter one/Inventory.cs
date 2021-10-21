using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace chapter_one
{
    class Inventory
    {
        private List<Guitar> _guitars;

        public Inventory()
        {
            this._guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber,Builder builder , Type type, string backwood,string topwood , double price)
        {
            Guitar guitar = new Guitar(serialNumber, builder, type, backwood, topwood, price);
            this._guitars.Add(guitar);
        }

        public Guitar GetGuitar(string searialNumber)
        {
            foreach (var guitar in this._guitars)
            {
                if (guitar.GetSerialNumber() == searialNumber)
                {
                    return guitar;
                }
            }

            return null;
        }

        private bool GuitarSpecSearch(Guitar userType , Guitar item)
        {
          
            if ( userType.Gspec().GetType() == item.Gspec().GetType())
            {
                return true;
            }

            return false;
        }

        public Guitar Search(Guitar searchGuitar)
        {
            foreach (var guitar in this._guitars)
            {
                // this thing is not great why because search whats to know each and eveyr internal type of the guitars 
                // this one day you going to introduce new type to the guitar ( for example what type of strings [ nilone or iron ] ) 
                // then you have to update all the code based on the search algorithum ''' very bad .... 
                
                
                // another thing to compare single string you retreive whole guitart class === not good
                if (this. GuitarSpecSearch(searchGuitar,guitar) )
                {
                    continue;
                }
                
                return guitar;
            }

            return null;
        }
    }
}