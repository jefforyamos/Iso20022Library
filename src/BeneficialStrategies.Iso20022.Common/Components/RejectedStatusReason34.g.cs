﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectedStatusReason34.  ISO2002 ID# _cVfl4fNfEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected instruction status.
/// </summary>
[IsoId("_cVfl4fNfEeqRfth943bvEA")]
[DisplayName("Rejected Status Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectedStatusReason34
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectedStatusReason34 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectedStatusReason34( RejectedReason36Choice_ reqReasonCode )
    {
        ReasonCode = reqReasonCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_cp36Y_NfEeqRfth943bvEA")]
    [DisplayName("Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnCd")]
    #endif
    [IsoXmlTag("RsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedReason36Choice_ ReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedReason36Choice_ ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedReason36Choice_ ReasonCode { get; init; } 
    #else
    public RejectedReason36Choice_ ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the rejection status.
    /// </summary>
    [IsoId("_cp36a_NfEeqRfth943bvEA")]
    [DisplayName("Additional Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRsnInf")]
    #endif
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReasonInformation { get; init; } 
    #else
    public System.String? AdditionalReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
