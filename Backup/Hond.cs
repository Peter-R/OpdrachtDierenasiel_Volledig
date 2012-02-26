using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtDierenasiel1
{
    /// <summary>
    /// Een <b>hond</b> heeft, net als en huisdier,  een chipnummer, een geboortejaar en een roepnaam. Verder wordt vastgelegd of het huisdier gereserveerd is of niet. 
    /// Verder wordt van elke hond bijgehouden wanneer deze voor het laatst uitgelaten is. Indien de laatst uitgelaten dag onbekend is, is dit 00:00:0000.</summary>
    public class Hond : Huisdier
    {
        private int uitlaatdag, uitlaatmaand, uitlaatjaar;


        /// <summary>
        /// <p>deze constructor creert een hond volgens opgegeven chipnummer, geboortejaar, roepnaam en wel/niet gereserveerd.</p>
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
        ///
        /// <p>De dag, waarop de hond voor het laatst uitgelaten werd, is 00:00:0000.</p> 
        /// </summary>
        /// <param name="chipnummer">de eerste 5 karakters van deze string worden opgeslagen</param>
        /// <param name="geboortejaar">jaar van geboorte van het huisdier</param>
        /// <param name="roepnaam">de roepnaam van het huisdier</param>
        /// <param name="gereserveerd">of het huisdier is gereserveerd</param>
        public Hond(string chipnummer, int geboortejaar, string roepnaam, bool gereserveerd)
        {
           //moet je nog maken
        }

        /// <summary>
        /// Alle informatie met betrekking tot hond is opgeleverd in de voorgeschreven vorm
        /// </summary>
        /// <returns>een string van de vorm: eerst "HOND: ", dan het vijfcijferige chipnummer, dan een komma, dan een spatie,
        /// dan een viercijferig geboortejaar ("0000" indien onbekend), dan een komma, dan een spatie,
        /// dan de roepnaam, dan een spatie en 
        /// dan "gereserveerd" of "niet gereserveerd", al naar gelang het dier gereserveerd is,
        /// dan een komma en de dag waarop de hond voor het laatst uitgelaten is.
        /// </returns>
        public override string GetInfo()
        {
            //moet je nog maken

            return "volgt nog";
        }
    }
}
