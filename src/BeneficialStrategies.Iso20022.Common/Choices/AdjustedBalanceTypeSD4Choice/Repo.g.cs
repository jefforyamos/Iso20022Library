﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Repo.  ISO2002 ID# _RnUrWcSTEeeRJJtE9TSlkw.
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
namespace BeneficialStrategies.Iso20022.Choices.AdjustedBalanceTypeSD4Choice
{
    /// <summary>
    /// Repurchase agreement (REPO) between a seller and a buyer whereby the seller agrees to repurchase the securities at an agreed upon price, and usually at a stated time.
    /// </summary>
    [IsoId("_RnUrWcSTEeeRJJtE9TSlkw")]
    [DisplayName("Repo")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Repo : AdjustedBalanceTypeSD4Choice_
    #else
    public partial class Repo : AdjustedBalanceTypeSD4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Repo instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Repo( ShortLong1Code reqShortLongPosition,FinancialInstrumentQuantity15Choice_ reqQuantity )
        {
            ShortLongPosition = reqShortLongPosition;
            Quantity = reqQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_cfsEf5KQEeWHWpTQn1FFVg")]
        [DisplayName("Short Long Position")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrtLngPos")]
        #endif
        [IsoXmlTag("ShrtLngPos")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ShortLong1Code ShortLongPosition { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ShortLong1Code ShortLongPosition { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ShortLong1Code ShortLongPosition { get; init; } 
        #else
        public ShortLong1Code ShortLongPosition { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_cfsEgZKQEeWHWpTQn1FFVg")]
        [DisplayName("Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qty")]
        #endif
        [IsoXmlTag("Qty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
        #else
        public FinancialInstrumentQuantity15Choice_ Quantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
