﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SettlementReportingInitiation.  ISO2002 ID# __WOCMFZXEeen1vB4iz5SyA.
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
namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice
{
    /// <summary>
    /// Settlement reporting initiation message record.
    /// </summary>
    [IsoId("__WOCMFZXEeen1vB4iz5SyA")]
    [DisplayName("Settlement Reporting Initiation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SettlementReportingInitiation : RecordMessage1Choice_
    #else
    public partial class SettlementReportingInitiation : RecordMessage1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SettlementReportingInitiation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SettlementReportingInitiation( System.Byte[] reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Binary data of 2MB maximum.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmRptgInitn")]
        #endif
        [IsoXmlTag("SttlmRptgInitn")]
        [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax2MBBinary Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Byte[] Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[] Value { get; init; } 
        #else
        public System.Byte[] Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
