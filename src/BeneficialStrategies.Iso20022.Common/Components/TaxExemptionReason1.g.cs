﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxExemptionReason1.  ISO2002 ID# _VSvC-9p-Ed-ak6NoX_4Aeg_1927276750.
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
/// Specification of the tax exemption reason.
/// </summary>
[IsoId("_VSvC-9p-Ed-ak6NoX_4Aeg_1927276750")]
[DisplayName("Tax Exemption Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxExemptionReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxExemptionReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxExemptionReason1( TaxExemptReason2Code reqStructured )
    {
        Structured = reqStructured;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VSvC_Np-Ed-ak6NoX_4Aeg_1975300897")]
    [DisplayName("Structured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strd")]
    #endif
    [IsoXmlTag("Strd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxExemptReason2Code Structured { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxExemptReason2Code Structured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxExemptReason2Code Structured { get; init; } 
    #else
    public TaxExemptReason2Code Structured { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the type of tax.
    /// </summary>
    [IsoId("_VSvC_dp-Ed-ak6NoX_4Aeg_1975301750")]
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
