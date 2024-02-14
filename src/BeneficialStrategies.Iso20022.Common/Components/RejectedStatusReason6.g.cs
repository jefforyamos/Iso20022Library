﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectedStatusReason6.  ISO2002 ID# _U3LIWdp-Ed-ak6NoX_4Aeg_-136853846.
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
/// Reason for a rejected status.
/// </summary>
[IsoId("_U3LIWdp-Ed-ak6NoX_4Aeg_-136853846")]
[DisplayName("Rejected Status Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectedStatusReason6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectedStatusReason6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectedStatusReason6( RejectedStatusReason5Code reqStructured )
    {
        Structured = reqStructured;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for a rejected status in structured form.
    /// </summary>
    [IsoId("_U3LIWtp-Ed-ak6NoX_4Aeg_-136853820")]
    [DisplayName("Structured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strd")]
    #endif
    [IsoXmlTag("Strd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatusReason5Code Structured { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedStatusReason5Code Structured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatusReason5Code Structured { get; init; } 
    #else
    public RejectedStatusReason5Code Structured { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for a rejected status in free format text.
    /// </summary>
    [IsoId("_U3LIW9p-Ed-ak6NoX_4Aeg_-136853509")]
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
