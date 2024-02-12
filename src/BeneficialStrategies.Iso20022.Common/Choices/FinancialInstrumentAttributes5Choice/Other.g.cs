﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _6geZA5icEe2f7NHvXATP5g.
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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAttributes5Choice
{
    /// <summary>
    /// Description of the financial instrument, such as a a derivative, when the instrument is not admitted to trading on a trading venue.
    /// </summary>
    [IsoId("_6geZA5icEe2f7NHvXATP5g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Other : FinancialInstrumentAttributes5Choice_
    #else
    public partial class Other : FinancialInstrumentAttributes5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Other instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Other( SecurityInstrumentDescription23 reqFinancialInstrumentGeneralAttributes,DerivativeInstrument6 reqDerivativeInstrumentAttributes )
        {
            FinancialInstrumentGeneralAttributes = reqFinancialInstrumentGeneralAttributes;
            DerivativeInstrumentAttributes = reqDerivativeInstrumentAttributes;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_2oQU0ZidEe2f7NHvXATP5g")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Financial Instrument General Attributes")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; init; } 
        #else
        public SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_2oQU05idEe2f7NHvXATP5g")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Debt Instrument Attributes")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
        #else
        public DebtInstrument4? DebtInstrumentAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_2oQU1ZidEe2f7NHvXATP5g")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Derivative Instrument Attributes")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
        #else
        public DerivativeInstrument6 DerivativeInstrumentAttributes { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
