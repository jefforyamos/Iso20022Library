﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MultiCommodityExotic.  ISO2002 ID# _lThdd3vyEeanCNPcMT7sSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity3Choice
{
    /// <summary>
    /// Multi Commodity Exotic.
    /// </summary>
    [IsoId("_lThdd3vyEeanCNPcMT7sSg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Multi Commodity Exotic")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MultiCommodityExotic : AssetClassCommodity3Choice_
    #else
    public partial class MultiCommodityExotic : AssetClassCommodity3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MultiCommodityExotic instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MultiCommodityExotic( AssetClassProductType13Code reqBaseProduct )
        {
            BaseProduct = reqBaseProduct;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_6Eul4Fr0EeWN79Bl6BUd3g")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Base Product")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassProductType13Code BaseProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AssetClassProductType13Code BaseProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassProductType13Code BaseProduct { get; init; } 
        #else
        public AssetClassProductType13Code BaseProduct { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
