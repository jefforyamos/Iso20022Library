﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ISIN.  ISO2002 ID# _HYrJUX5aEea2k7EBUopqxw.
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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument48Choice
{
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_HYrJUX5aEea2k7EBUopqxw")]
    [DisplayName("ISIN")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ISIN : FinancialInstrument48Choice_
    #else
    public partial class ISIN : FinancialInstrument48Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ISIN instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ISIN( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// The International Securities Identification Number is a code allocated to financial instruments as well as referential instruments, as described in the ISO 6166 standard, associated with the minimum descriptive data.  The ISIN consists of a prefix using the alpha-2 country codes or reserved codes specified in ISO 3166 or other prefixes as may be determined by the Registration Authority for the ISO 6166 standard, a nine characters (alphanumeric) basic code and a check digit.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ISIN")]
        #endif
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISINOct2015Identifier Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
