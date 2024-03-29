﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OliveOil.  ISO2002 ID# _VQFYYw2jEeW72qLtWESimw.
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
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityAgricultural1Choice
{
    /// <summary>
    /// Olive oil agricultural commodity derivative.
    /// </summary>
    [IsoId("_VQFYYw2jEeW72qLtWESimw")]
    [DisplayName("Olive Oil")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OliveOil : AssetClassCommodityAgricultural1Choice_
    #else
    public partial class OliveOil : AssetClassCommodityAgricultural1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OliveOil instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OliveOil( AssetClassProductType1Code reqBaseProduct,AssetClassSubProductType3Code reqSubProduct )
        {
            BaseProduct = reqBaseProduct;
            SubProduct = reqSubProduct;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_NtOq5g2jEeW72qLtWESimw")]
        [DisplayName("Base Product")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BasePdct")]
        #endif
        [IsoXmlTag("BasePdct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassProductType1Code BaseProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AssetClassProductType1Code BaseProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassProductType1Code BaseProduct { get; init; } 
        #else
        public AssetClassProductType1Code BaseProduct { get; set; } 
        #endif
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_NtOq5Q2jEeW72qLtWESimw")]
        [DisplayName("Sub Product")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SubPdct")]
        #endif
        [IsoXmlTag("SubPdct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassSubProductType3Code SubProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AssetClassSubProductType3Code SubProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassSubProductType3Code SubProduct { get; init; } 
        #else
        public AssetClassSubProductType3Code SubProduct { get; set; } 
        #endif
        
        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_NtOq5w2jEeW72qLtWESimw")]
        [DisplayName("Additional Sub Product")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlSubPdct")]
        #endif
        [IsoXmlTag("AddtlSubPdct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AssetClassDetailedSubProductType4Code? AdditionalSubProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassDetailedSubProductType4Code? AdditionalSubProduct { get; init; } 
        #else
        public AssetClassDetailedSubProductType4Code? AdditionalSubProduct { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
