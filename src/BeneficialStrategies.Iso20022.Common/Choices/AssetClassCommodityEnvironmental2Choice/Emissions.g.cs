﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Emissions.  ISO2002 ID# _g7vTsbvwEeiLRYqS-r-R-A.
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
    /// Emissions environmental commodity derivative.
    /// </summary>
    [IsoId("_g7vTsbvwEeiLRYqS-r-R-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Emissions")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Emissions : AssetClassCommodityEnvironmental2Choice_
    #else
    public partial class Emissions : AssetClassCommodityEnvironmental2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Emissions instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Emissions( AssetClassProductType3Code reqBaseProduct,AssetClassSubProductType10Code reqSubProduct,AssetClassDetailedSubProductType8Code reqAdditionalSubProduct )
        {
            BaseProduct = reqBaseProduct;
            SubProduct = reqSubProduct;
            AdditionalSubProduct = reqAdditionalSubProduct;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_yww64bv4EeiLRYqS-r-R-A")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Base Product")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassProductType3Code BaseProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AssetClassProductType3Code BaseProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassProductType3Code BaseProduct { get; init; } 
        #else
        public AssetClassProductType3Code BaseProduct { get; set; } 
        #endif
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_yww647v4EeiLRYqS-r-R-A")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Sub Product")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassSubProductType10Code SubProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AssetClassSubProductType10Code SubProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassSubProductType10Code SubProduct { get; init; } 
        #else
        public AssetClassSubProductType10Code SubProduct { get; set; } 
        #endif
        
        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_yww65bv4EeiLRYqS-r-R-A")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Additional Sub Product")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassDetailedSubProductType8Code AdditionalSubProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AssetClassDetailedSubProductType8Code AdditionalSubProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassDetailedSubProductType8Code AdditionalSubProduct { get; init; } 
        #else
        public AssetClassDetailedSubProductType8Code AdditionalSubProduct { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
