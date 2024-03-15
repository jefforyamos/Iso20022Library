﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PolishNationalClearingCode.  ISO2002 ID# _TDPFhNp-Ed-ak6NoX_4Aeg_-1877438256.
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
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Polish National Clearing Code - identifies Polish financial institutions on the Polish national clearing system.
    /// </summary>
    [IsoId("_TDPFhNp-Ed-ak6NoX_4Aeg_-1877438256")]
    [DisplayName("Polish National Clearing Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PolishNationalClearingCode : ClearingSystemMemberIdentification2Choice_
    #else
    public partial class PolishNationalClearingCode : ClearingSystemMemberIdentification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PolishNationalClearingCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PolishNationalClearingCode( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Polish National Clearing Code Identifier. Identifies Polish financial institutions on the Polish national clearing system.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PLKNR")]
        #endif
        [IsoXmlTag("PLKNR")]
        [IsoSimpleType(IsoSimpleType.PolishNationalClearingCodeIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoPolishNationalClearingCodeIdentifier Value { get; init; } 
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
