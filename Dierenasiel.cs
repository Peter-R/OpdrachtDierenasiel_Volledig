using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtDierenasiel1
{
    class Dierenasiel
    {
        /// <summary>
        /// velden van dierenasiel
        /// </summary>
        List<Huisdier> huisdieren;

        /// <summary>
        /// Naam dierenasiel
        /// </summary>
        public string Naam
        {
            get;
            private set;
        }

        /// <summary>
        /// Capaciteit dierenasiel
        /// </summary>
        public int Capaciteit
        {
            get;
            private set;
        }

        /// <summary>
        /// Aantal dieren aanwezig
        /// </summary>
        public int AantalHuisdierenAanwezig
        {
            get { return huisdieren.Count; }
        }

        /// <summary>
        /// ALS in het dierenasiel al een huisdier voorkomt met 
        /// chipnummer gelijk aan chipnr,
        /// DAN is de returnwaarde dat betreffende huisdier 
        /// ANDERS is de returnwaarde gelijk aan null 
        /// </summary>
        /// <param name="chipnr">het chipnummer</param>        
        public Huisdier GetHuisdierMetChipnummer(string chipnr)
        {
            foreach (Huisdier h in huisdieren)
                if (h.Chipnummer == chipnr)
                    return h;

            return null;
        }

        public Huisdier GetHuisdierMetIndex(int index)
        {
            try
            {
                return huisdieren[index];
            }
            catch
            {
                throw new Exception("De opgegeven index valt buiten het bereik!");
            }
        }

        /// <summary>
        /// ALS in het dierenasiel al een huisdier voorkomt met 
        /// chipnummer gelijk dat van h, of als het asiel vol is,
        /// DAN is de returnwaarde false (en h is niet toegevoegd) 
        /// ANDERS is de returnwaarde true en is h toegevoegd 
        /// </summary>
        /// <param name="h">het toe te voegen huisdier</param>        
        public bool VoegHuisdierToe(Huisdier h)
        {
            if (huisdieren.Count < Capaciteit)
            {
                if (GetHuisdierMetChipnummer(h.Chipnummer) == null)
                {
                    huisdieren.Add(h);
                    return true;
                }                                                
            }

            return false;
        }

        /// <summary>
        /// ALS in het dierenasiel een huisdier voorkomt met 
        /// chipnummer gelijk aan chipnr,
        /// DAN is de returnwaarde true en is het betreffende 
        /// huisdier verwijderd, 
        /// ANDERS is de returnwaarde false en is niets verwijderd 
        /// </summary>
        /// <param name="chipnr">het chipnummer dat hoort bij het te verwijderen huishier</param>
        /// <returns></returns>
        public bool VerwijderHuisdier(string chipnr)
        {
            for (int index = 0; index < huisdieren.Count; index++)
            {
                if (huisdieren[index].Chipnummer == chipnr)
                {
                    huisdieren.RemoveAt(index);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public Huisdier KloonHuisdier(Huisdier h)
        {
            return (Huisdier)h.Clone();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="capaciteit"></param>
        public Dierenasiel(string naam, int capaciteit)
        {
            this.Naam = naam;
            this.Capaciteit = capaciteit;
            huisdieren = new List<Huisdier>();
        }
    }
}
