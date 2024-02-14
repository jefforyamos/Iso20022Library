﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionMovementProcessingStatus1.  ISO2002 ID# _Rkw8ZNp-Ed-ak6NoX_4Aeg_-1849557856.
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
/// Provide processing status information of a movement.
/// </summary>
[IsoId("_Rkw8ZNp-Ed-ak6NoX_4Aeg_-1849557856")]
[DisplayName("Corporate Action Movement Processing Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementProcessingStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovementProcessingStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementProcessingStatus1( ProcessedStatus3FormatChoice_ reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_Rkw8Zdp-Ed-ak6NoX_4Aeg_-1819081632")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessedStatus3FormatChoice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessedStatus3FormatChoice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessedStatus3FormatChoice_ Status { get; init; } 
    #else
    public ProcessedStatus3FormatChoice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rkw8Ztp-Ed-ak6NoX_4Aeg_-1819081353")]
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
