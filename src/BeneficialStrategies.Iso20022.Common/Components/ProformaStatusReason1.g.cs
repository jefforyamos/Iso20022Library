﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProformaStatusReason1.  ISO2002 ID# _GeducUzDEeafiMTDrtSnyw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Reason for an proforma status.
/// </summary>
[IsoId("_GeducUzDEeafiMTDrtSnyw")]
[DisplayName("Proforma Status Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProformaStatusReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProformaStatusReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProformaStatusReason1( ProformaStatusReason2Choice_ reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the proforma account status.
    /// </summary>
    [IsoId("_G4DTIUzDEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProformaStatusReason2Choice_ Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProformaStatusReason2Choice_ Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProformaStatusReason2Choice_ Code { get; init; } 
    #else
    public ProformaStatusReason2Choice_ Code { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the reason for the proforma account status.
    /// </summary>
    [IsoId("_G4DTI0zDEeafiMTDrtSnyw")]
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
