﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubstitutionResponse1.  ISO2002 ID# _QnhRA9p-Ed-ak6NoX_4Aeg_908779595.
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
/// Provides details about the collateral substitution response.
/// </summary>
[IsoId("_QnhRA9p-Ed-ak6NoX_4Aeg_908779595")]
[DisplayName("Substitution Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubstitutionResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubstitutionResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubstitutionResponse1( Status4Code reqResponseType )
    {
        ResponseType = reqResponseType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if the substitution request was accepted or rejected.
    /// </summary>
    [IsoId("_QnhRBNp-Ed-ak6NoX_4Aeg_-1628822565")]
    [DisplayName("Response Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnTp")]
    #endif
    [IsoXmlTag("RspnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status4Code ResponseType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status4Code ResponseType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status4Code ResponseType { get; init; } 
    #else
    public Status4Code ResponseType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the accepted collateral substitution.
    /// </summary>
    [IsoId("_QnhRBdp-Ed-ak6NoX_4Aeg_-691288487")]
    [DisplayName("Collateral Substitution Acceptance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnAccptncDtls")]
    #endif
    [IsoXmlTag("CollSbstitnAccptncDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralSubstitutionResponse1? CollateralSubstitutionAcceptanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralSubstitutionResponse1? CollateralSubstitutionAcceptanceDetails { get; init; } 
    #else
    public CollateralSubstitutionResponse1? CollateralSubstitutionAcceptanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the rejected collateral substitution.
    /// </summary>
    [IsoId("_QnhRBtp-Ed-ak6NoX_4Aeg_-417549319")]
    [DisplayName("Collateral Substitution Rejection Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnRjctnDtls")]
    #endif
    [IsoXmlTag("CollSbstitnRjctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralSubstitutionResponse2? CollateralSubstitutionRejectionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralSubstitutionResponse2? CollateralSubstitutionRejectionDetails { get; init; } 
    #else
    public CollateralSubstitutionResponse2? CollateralSubstitutionRejectionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
