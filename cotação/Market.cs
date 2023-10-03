using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotação
{
    public class Market
    {
        public Market()
        {
            this.currency = new Currency();
        }
        [JsonProperty(PropertyName = "currencies")]
        public Currency currency { get; set; }
    }
}
