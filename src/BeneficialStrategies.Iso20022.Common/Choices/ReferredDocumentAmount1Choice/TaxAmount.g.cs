﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TaxAmount.  ISO2002 ID# _QGJCR9p-Ed-ak6NoX_4Aeg_-888106455.
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
namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentAmount1Choice
{
    /// <summary>
    /// Quantity of cash resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_QGJCR9p-Ed-ak6NoX_4Aeg_-888106455")]
    [DisplayName("Tax Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TaxAmount : ReferredDocumentAmount1Choice_
    #else
    public partial class TaxAmount : ReferredDocumentAmount1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TaxAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TaxAmount( System.Decimal reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217. The decimal separator is a dot.|Note: A zero amount is considered a positive amount.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxAmt")]
        #endif
        [IsoXmlTag("TaxAmt")]
        [IsoSimpleType(IsoSimpleType.CurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoCurrencyAndAmount Value { get; init; } 
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
