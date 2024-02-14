﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MonetaryValue.  ISO2002 ID# _AqItc4IiEeW_KPkCyw2GUA.
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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity25Choice
{
    /// <summary>
    /// TBC.
    /// </summary>
    [IsoId("_AqItc4IiEeW_KPkCyw2GUA")]
    [DisplayName("Monetary Value")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MonetaryValue : FinancialInstrumentQuantity25Choice_
    #else
    public partial class MonetaryValue : FinancialInstrumentQuantity25Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MonetaryValue instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MonetaryValue( System.Decimal reqValue )
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
        [DataMember(Name="MntryVal")]
        #endif
        [IsoXmlTag("MntryVal")]
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
