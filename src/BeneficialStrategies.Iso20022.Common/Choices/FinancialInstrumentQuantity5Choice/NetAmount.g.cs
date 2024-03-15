﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NetAmount.  ISO2002 ID# _SoaxxNp-Ed-ak6NoX_4Aeg_1036646757.
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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity5Choice
{
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold.
    /// </summary>
    [IsoId("_SoaxxNp-Ed-ak6NoX_4Aeg_1036646757")]
    [DisplayName("Net Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NetAmount : FinancialInstrumentQuantity5Choice_
    #else
    public partial class NetAmount : FinancialInstrumentQuantity5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NetAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NetAmount( System.Decimal reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A number of monetary units specified in an active or a historic currency where the unit of currency is explicit and compliant with ISO 4217.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NetAmt")]
        #endif
        [IsoXmlTag("NetAmt")]
        [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal Value { get; init; } 
        #else
        public System.Decimal Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
