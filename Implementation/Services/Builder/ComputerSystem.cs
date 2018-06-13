using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Implementation.Services.Builder
{
    public class ComputerSystem
    {
        private string _RAM;
        private string _HDD;

        public ComputerSystem(string RAM, string HDD)
        {
            _HDD = HDD;
            _RAM = RAM;
        }

        public string Build()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format(" RAM: {0}", _RAM));

            sb.Append(string.Format(" HDD: {0}", _HDD));

            return sb.ToString();
        }

    }
}