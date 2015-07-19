﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RiotNet.Converters;

namespace RiotNet.Models
{
    /// <summary>
    /// Represents a champion ability or summoner spell.
    /// </summary>
    public class StaticSpell
    {
        /// <summary>
        /// Gets or sets the cooldowns of this spell at each rank.
        /// </summary>
        public ListOfDouble Cooldown { get; set; }

        /// <summary>
        /// Gets or sets the cooldown at all ranks merged into a single string.
        /// </summary>
        public string CooldownBurn { get; set; }

        /// <summary>
        /// Gets or sets the mana (or other resource) cost of the spell.
        /// </summary>
        public ListOfInt Cost { get; set; }

        /// <summary>
        /// Gets or sets the cost at all ranks merged into a single string.
        /// </summary>
        public string CostBurn { get; set; }

        /// <summary>
        /// Gets or sets the type of resource that this spell costs.
        /// </summary>
        public string CostType { get; set; }

        /// <summary>
        /// Gets or sets the description of the spell.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the effect of the spell at each rank.
        /// </summary>
        public ListOfListOfDouble Effect { get; set; }

        /// <summary>
        /// Gets or sets the effects at all ranks, merged into a single string for each effect.
        /// </summary>
        public ListOfString EffectBurn { get; set; }

        /// <summary>
        /// Gets or sets the image data for the current spell.
        /// </summary>
        public virtual StaticImage Image { get; set; }

        /// <summary>
        /// Gets or sets the key of the current spell.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the level-up tooltip of the current spell.
        /// </summary>
        [JsonProperty("leveltip")]
        public LevelTip LevelTip { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of points that a player can put into this spell.
        /// </summary>
        [JsonProperty("maxrank")]
        public int MaxRank { get; set; }

        /// <summary>
        /// Gets or sets the name of the spell.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the range of the spell at each rank. A list with a single entry of 0 indicates that the spell is self-cast.
        /// </summary>
        [JsonConverter(typeof(RangeConverter))]
        public ListOfInt Range { get; set; }

        /// <summary>
        /// Gets or sets the range at all ranks merged into a single string.
        /// </summary>
        public string RangeBurn { get; set; }

        /// <summary>
        /// Gets or sets the cost and type of resource that the spell uses.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the sanitized descrption of the spell.
        /// </summary>
        public string SanitizedDescription { get; set; }

        /// <summary>
        /// Gets or sets the sanitized spell tooltip.
        /// </summary>
        public string SanitizedTooltip { get; set; }

        /// <summary>
        /// Gets or sets the spell tooltip.
        /// </summary>
        public string Tooltip { get; set; }

        /// <summary>
        /// Gets or sets the scaling coefficients of the spell.
        /// </summary>
        public virtual List<SpellVars> Vars { get; set; }

    }
}
