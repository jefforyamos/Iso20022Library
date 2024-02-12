﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalStatus2.  ISO2002 ID# _RDPjttp-Ed-ak6NoX_4Aeg_1264973703.
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
/// Status advising on the rejection of the instruction or cancellation request.
/// </summary>
[IsoId("_RDPjttp-Ed-ak6NoX_4Aeg_1264973703")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Additional Status")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalStatus2( CancellationRejectionStatus1Choice_ reqReason )
    {
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason advising the rejection of the instruction cancellation request.
    /// </summary>
    [IsoId("_RDPjt9p-Ed-ak6NoX_4Aeg_1264974188")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationRejectionStatus1Choice_ Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CancellationRejectionStatus1Choice_ Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRejectionStatus1Choice_ Reason { get; init; } 
    #else
    public CancellationRejectionStatus1Choice_ Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the reason.
    /// </summary>
    [IsoId("_RDPjuNp-Ed-ak6NoX_4Aeg_1264973826")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
