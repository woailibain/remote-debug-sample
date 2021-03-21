using System.Collections.Generic;
using System.Linq;
using kiwiho.example.Basket.API.Model;

namespace kiwiho.example.Basket.API.Repository
{
    public class BasketRepository
    {
        public static List<CustomerBasket> _data = new ();

        static BasketRepository(){
            _data.Add(new("kiwiho.cus.1"));
            _data.Add(new("kiwiho.cus.2"));
            _data.Add(new("kiwiho.cus.3"));
            _data.Add(new("kiwiho.cus.4"));
            _data.Add(new("kiwiho.cus.5"));
            _data.Add(new("kiwiho.cus.6"));
            _data.Add(new("kiwiho.cus.7"));

            var s = new CustomerBasket("john");
            s.Items.Add(new(){ProductName="Apple"});
            // _data.Add(s);
        }

        public CustomerBasket Get(string id){

            return _data.FirstOrDefault(r=>r.BuyerId == id);

        }
    }
}