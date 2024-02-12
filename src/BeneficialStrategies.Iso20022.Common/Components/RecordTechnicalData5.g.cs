﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RecordTechnicalData5.  ISO2002 ID# _XjVHpZ26Eeuwmdq0KtnICg.
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
/// Instrument specific technical data to support identification.
/// </summary>
[IsoId("_XjVHpZ26Eeuwmdq0KtnICg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Record Technical Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RecordTechnicalData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RecordTechnicalData5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RecordTechnicalData5( System.DateTime reqReceiptDateTime )
    {
        ReceiptDateTime = reqReceiptDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the date and time when the report was originally received by the national competent authority.
    /// </summary>
    [IsoId("_X5iBAZ26Eeuwmdq0KtnICg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Receipt Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ReceiptDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime ReceiptDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ReceiptDateTime { get; init; } 
    #else
    public System.DateTime ReceiptDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the reason for the exchange of the transaction report between the competent authorities.
    /// </summary>
    [IsoId("_X5iBA526Eeuwmdq0KtnICg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exchange Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public ExternalAuthorityExchangeReason1Code? ExchangeReason { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _X5iBA526Eeuwmdq0KtnICg
    
    
    #nullable disable
    
}
