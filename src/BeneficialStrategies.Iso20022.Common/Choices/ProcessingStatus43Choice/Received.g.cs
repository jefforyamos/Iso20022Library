﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Received.  ISO2002 ID# _T_H5oVhGEeOMYfRGLS0NbA.
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
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus43Choice
{
    /// <summary>
    /// Status of the standing settlement instruction, cancellation or deletion is received for further processing.
    /// </summary>
    [IsoId("_T_H5oVhGEeOMYfRGLS0NbA")]
    [DisplayName("Received")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Received : ProcessingStatus43Choice_
    #else
    public partial class Received : ProcessingStatus43Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Received instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Received( ReceivedReason1Choice_ reqReason )
        {
            Reason = reqReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for the received status.
        /// </summary>
        [IsoId("_Kak_EFj7EeOgwYxfAV02bg")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReceivedReason1Choice_ Reason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReceivedReason1Choice_ Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReceivedReason1Choice_ Reason { get; init; } 
        #else
        public ReceivedReason1Choice_ Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the processed instruction.
        /// </summary>
        [IsoId("_Kak_C1j7EeOgwYxfAV02bg")]
        [DisplayName("Additional Reason Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlRsnInf")]
        #endif
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalReasonInformation { get; init; } 
        #else
        public System.String? AdditionalReasonInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
