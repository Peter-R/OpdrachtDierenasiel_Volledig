using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtDierenasiel1
{
    /// <summary>
    /// Een <b>huisdier</b> heeft een chipnummer, een geboortejaar en een roepnaam. Verder wordt vastgelegd of het huisdier gereserveerd is of niet. 
    /// </summary>
    public class Huisdier
    {
        /// <summary>
        /// velden van huisdier
        /// </summary>
        private String chipnummer;
        private int geboortejaar;
        private string roepnaam;
        private bool gereserveerd;

        /// <summary>
        /// <p>deze constructor creert een huisdier volgens opgegeven chipnummer, geboortejaar, roepnaam en wel/niet gereserveerd.</p>
        /// 
        /// <p>Het chipnummer wordt altijd als een string met lengte 5 opgeslagen.<p>
        /// Indien het opgegeven chipnummer te kort is, dan wordt het 'aan de voorkant' aangevuld met nullen.</p>
        /// <p>Indien het opgegeven chipnummer te lang is, dan worden alleen de eerste 5 karakters opgeslagen.</p>
        /// </p> 
        /// <p>Het geboortejaar wordt opgeslagen als een 4-cijferig getal, indien het geboortejaar bekend is. Anders wordt -1 opgeslagen.</p> 
        ///
        /// <p>De naam van het dier wordt opgeslagen in roepnaam, indien bekend. Indien onbekend, dan is de
        /// roepnaam mits roepnaam gelijk aan "noname"</p> 
        ///
        /// <p>Indien afgesproken is dat het huisdier door een (toekomstige) eigenaar wordt opgehaald,
        /// dan is de boolean gereserveerd gelijk aan true; en anders is die boolean false.</p> 
        /// </summary>
        /// <param name="chipnummer">de eerste 5 karakters van deze string worden opgeslagen</param>
        /// <param name="geboortejaar">jaar van geboorte van het huisdier</param>
        /// <param name="roepnaam">de roepnaam van het huisdier</param>
        /// <param name="gereserveerd">of het huisdier is gereserveerd</param>
        public Huisdier(String chipnummer, int geboortejaar, String roepnaam, bool gereserveerd )
        {
            String s = chipnummer;
            while (s.Length < 5)
            {
                s = "0" + s;
            }
            s = s.Substring(0, 5);
            this.chipnummer = s;

            if (geboortejaar > 1990 && geboortejaar < 3000)
                this.geboortejaar = geboortejaar;
            else
                this.geboortejaar = 0;

            if (roepnaam == "")
                this.roepnaam = "noname";
            else
                this.roepnaam = roepnaam;

            this.gereserveerd = gereserveerd;
        }

       
        /// <summary>
        /// <p>deze constructor creert een huisdier met chipnummer "00000",
        /// geboortejaar 0, roepnaam "noname" en is niet gereserveerd.</p>
        /// </summary>
        public Huisdier()
            :this("00000", 0, "noname", false)
        {      
        }

        /// <summary>
        /// het chipnummer van het huisdier
        /// </summary>
        public String Chipnummer
        {
            get 
            { 
                return chipnummer;
            }
        }

        /// <summary>
        /// het geboortejaar van het huisdier
        /// </summary>
        public int Geboortejaar
        {
            get
            {
                return geboortejaar;
            }
        }
        
        /// <summary>
        /// Alle informatie met betrekking tot huisdier is opgeleverd in de voorgeschreven vorm
        /// </summary>
        /// <returns>een string van de vorm: eerst het vijfcijferige chipnummer, dan een komma, dan een spatie,
        /// dan een viercijferig geboortejaar ("0000" indien onbekend), dan een komma, dan een spatie,
        /// dan de roepnaam, dan een spatie en 
        /// dan "gereserveerd" of "niet gereserveerd", al naar gelang het dier gereserveerd is.
        /// </returns>
        public virtual String GetInfo()
        {
            String h;
            String stringjaar;
            if (geboortejaar == 0) stringjaar = "0000";
            else stringjaar = Convert.ToString(geboortejaar);

            h = chipnummer + ", " + stringjaar + ", " + roepnaam;
            if (gereserveerd)
                h = h + ", gereserveerd";
            else
                h = h + ", niet gereserveerd";

            return h;
        }
    }
}
