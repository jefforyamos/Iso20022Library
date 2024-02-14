﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessingStatus.  ISO2002 ID# _RWwVkNp-Ed-ak6NoX_4Aeg_-1271508072.
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
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus2Choice
{
    /// <summary>
    /// Status advising on the processing of the instruction.
    /// </summary>
    [IsoId("_RWwVkNp-Ed-ak6NoX_4Aeg_-1271508072")]
    [DisplayName("Processing Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProcessingStatus : InstructionStatus2Choice_
    #else
    public partial class ProcessingStatus : InstructionStatus2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProcessingStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProcessingStatus( Status3Code reqStatus )
        {
            Status = reqStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Status on the processing of the instructions.
        /// </summary>
        [IsoId("_RWwVk9p-Ed-ak6NoX_4Aeg_-316967473")]
        [DisplayName("Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sts")]
        #endif
        [IsoXmlTag("Sts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Status3Code Status { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Status3Code Status { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Status3Code Status { get; init; } 
        #else
        public Status3Code Status { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RWwVlNp-Ed-ak6NoX_4Aeg_-316967450")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalInformation { get; init; } 
        #else
        public System.String? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
