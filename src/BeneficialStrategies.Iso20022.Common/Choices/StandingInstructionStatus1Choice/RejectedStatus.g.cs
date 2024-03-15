﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectedStatus.  ISO2002 ID# _RirRsdp-Ed-ak6NoX_4Aeg_15156423.
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
namespace BeneficialStrategies.Iso20022.Choices.StandingInstructionStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RirRsdp-Ed-ak6NoX_4Aeg_15156423")]
    [DisplayName("Rejected Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RejectedStatus : StandingInstructionStatus1Choice_
    #else
    public partial class RejectedStatus : StandingInstructionStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_RlD3U9p-Ed-ak6NoX_4Aeg_-484468439")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason20FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason20FormatChoice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _RlD3U9p-Ed-ak6NoX_4Aeg_-484468439
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RlD3VNp-Ed-ak6NoX_4Aeg_-484468418")]
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
