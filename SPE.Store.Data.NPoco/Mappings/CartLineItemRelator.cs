using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Mappings
{
    public class CartLineItemRelator
    {
        public Cart current;
        public Cart MapIt(Cart cart, LineItem line)
        {
            // Terminating call.  Since we can return null from this function
            // we need to be ready for PetaPoco to callback later with null
            // parameters
            if (cart == null)
                return current;

            // Is this the same cart as the current one we're processing
            if (current != null && current.Id == cart.Id)
            {
                // Yes, just add this lines to the current cart's collection of lines
                current.Lines.Add(line);

                // Return null to indicate we're not done with this cart yet
                return null;
            }

            // This is a different cart to the current one, or this is the 
            // first time through and we don't have a cart yet

            // Save the current cart
            var prev = current;

            // Setup the new current cart
            current = cart;
            current.Lines = new List<LineItem>();
            if (line != null)
              current.Lines.Add(line);

            // Return the now populated previous cart (or null if first time through)
            return prev;
        }
    }
}
