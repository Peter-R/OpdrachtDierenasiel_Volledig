using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtDierenasiel1
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDier
    {
        /// <summary>
        /// Een vijfcijferig chipnummer
        /// </summary>
        string Chipnummer { get; } 

        /// <summary>
        /// Informatie over een dier
        /// </summary>        
        string GetInfo();       

        /// <summary>
        /// De prijs in euro's
        /// </summary>        
        int GetPrijs();       
    }
}
