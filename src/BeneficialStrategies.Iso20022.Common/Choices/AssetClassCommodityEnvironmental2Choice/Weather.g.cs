﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Weather.  ISO2002 ID# _g7vTs7vwEeiLRYqS-r-R-A.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnvironmental2Choice
{
    /// <summary>
    /// Weather environmental commodity derivative.
    /// </summary>
    [IsoId("_g7vTs7vwEeiLRYqS-r-R-A")]
    [DisplayName("Weather")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Weather : AssetClassCommodityEnvironmental2Choice_
    #else
    public partial class Weather : AssetClassCommodityEnvironmental2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Weather instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Weather( AssetClassProductType3Code reqBaseProduct,AssetClassSubProductType30Code reqSubProduct )
        {
            BaseProduct = reqBaseProduct;
            SubProduct = reqSubProduct;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_wxCesFrNEeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BasePdct")]
        #endif
        [IsoXmlTag("BasePdct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassProductType3Code BaseProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AssetClassProductType3Code BaseProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassProductType3Code BaseProduct { get; init; } 
        #else
        public AssetClassProductType3Code BaseProduct { get; set; } 
        #endif
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_zcOSkFrNEeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SubPdct")]
        #endif
        [IsoXmlTag("SubPdct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassSubProductType30Code SubProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AssetClassSubProductType30Code SubProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassSubProductType30Code SubProduct { get; init; } 
        #else
        public AssetClassSubProductType30Code SubProduct { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
