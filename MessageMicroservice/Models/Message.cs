using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageMicroservice.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 
        /// </summary>
        public int id_poruke { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime vreme { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tekst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id_kanala { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id_ucesnik { get; set; }
    }
}