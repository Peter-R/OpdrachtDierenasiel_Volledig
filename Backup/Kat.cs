using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtDierenasiel1
{
    /// <summary>
    /// Een <b>kat</b> heeft, net als en huisdier,  een chipnummer, een geboortejaar en een roepnaam. Verder wordt vastgelegd of het huisdier gereserveerd is of niet. 
    /// Verder wordt van elke kat extra informatie over zijn/haar gedrag bijgehouden.</summary>
    public class Kat : Huisdier
    {
        private String extraInfo;

        /// <summary>
        /// <p>deze constructor creert een kat volgens opgegeven chipnummer, geboortejaar, roepnaam en wel/niet gereserveerd.</p>
        /// 
        /// <p>Het chipnummer wordt altijd als een String met lengte 5 opgeslagen.<p>
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
        ///
        /// <p>In een string kan extra informatie over de kat opgeslagen worden.</p> 
        /// </summary>
        /// <param name="chipnummer">de eerste 5 karakters van deze string worden opgeslagen</param>
        /// <param name="geboortejaar">jaar van geboorte van het huisdier</param>
        /// <param name="roepnaam">de roepnaam van het huisdier</param>
        /// <param name="gereserveerd">of het huisdier is gereserveerd</param>
        /// <param name="extraInfo">extra informatie over de kat</param>
        public Kat(String chipnummer, int geboortejaar, String roepnaam, bool gereserveerd, String extraInfo)
        {
            //moet je nog maken
        }

        /// <summary>
        /// Alle informatie met betrekking tot hond is opgeleverd in de voorgeschreven vorm
        /// </summary>
        /// <returns>een string van de vorm: eerst "KAT: ", dan het vijfcijferige chipnummer, dan een komma, dan een spatie,
        /// dan een viercijferig geboortejaar ("0000" indien onbekend), dan een komma, dan een spatie,
        /// dan de roepnaam, dan een spatie en 
        /// dan "gereserveerd" of "niet gereserveerd", al naar gelang het dier gereserveerd is,
        /// vervolgens een komma gevolgd door spatie gevolgd door de extra informatie
        /// </returns>
        public override String GetInfo()
        {
            //moet je nog maken

            return "volgt nog";
        }
    }
}
