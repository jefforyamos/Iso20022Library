﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _P-QQoTq5EeWyoP0PbocV1Q.
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
namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason15Choice
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_P-QQoTq5EeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Code : AcknowledgementReason15Choice_
    #else
    public partial class Code : AcknowledgementReason15Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Code instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Code( AcknowledgementReason3Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information about the processed instruction.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cd")]
        #endif
        [IsoXmlTag("Cd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AcknowledgementReason3Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AcknowledgementReason3Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AcknowledgementReason3Code Value { get; init; } 
        #else
        public AcknowledgementReason3Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
