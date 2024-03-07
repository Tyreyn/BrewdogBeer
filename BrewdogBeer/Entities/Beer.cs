using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrewdogBeer.Entities.Elementary;

namespace BrewdogBeer.Entities
{
    /// <summary>
    /// The root beer entities.
    /// </summary>
    public class Beer
    {
        /// <summary>
        /// The beer id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The beer name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The beer tagline.
        /// </summary>
        public string tagline { get; set; }

        /// <summary>
        /// The beer first brewed.
        /// </summary>
        public string first_brewed { get; set; }

        /// <summary>
        /// The beer description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The beer image url.
        /// </summary>
        public string image_url { get; set; }

        /// <summary>
        /// The beer abv.
        /// </summary>
        public double abv { get; set; }

        /// <summary>
        /// The beer ibu.
        /// </summary>
        public double? ibu { get; set; }

        /// <summary>
        /// The beer target fg.
        /// </summary>
        public double target_fg { get; set; }

        /// <summary>
        /// The beer target og.
        /// </summary>
        public double target_og { get; set; }

        /// <summary>
        /// The beer ebc.
        /// </summary>
        public double? ebc { get; set; }

        /// <summary>
        /// The beer srm.
        /// </summary>
        public double? srm { get; set; }

        /// <summary>
        /// The beer ph.
        /// </summary>
        public double? ph { get; set; }

        /// <summary>
        /// The beer attentuation level.
        /// </summary>
        public double attenuation_level { get; set; }

        /// <summary>
        /// The beer volume.
        /// </summary>
        public Volume volume { get; set; }

        /// <summary>
        /// The beer boil volume.
        /// </summary>
        public BoilVolume boil_volume { get; set; }

        /// <summary>
        /// The beer making methods.
        /// </summary>
        public Method method { get; set; }

        /// <summary>
        /// The beer ingredients.
        /// </summary>
        public Ingredients ingredients { get; set; }

        /// <summary>
        /// The food pairing to beer list.
        /// </summary>
        public List<string> food_pairing { get; set; }

        /// <summary>
        /// The brewers tips.
        /// </summary>
        public string brewers_tips { get; set; }

        /// <summary>
        /// The beer contributor.
        /// </summary>
        public string contributed_by { get; set; }
    }
}
