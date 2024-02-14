﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BusinessError4.  ISO2002 ID# _P7y45ZJKEeuAlLVx8pyt3w.
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
/// Provides the business error details.
/// </summary>
[IsoId("_P7y45ZJKEeuAlLVx8pyt3w")]
[DisplayName("Business Error")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessError4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BusinessError4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BusinessError4( SecurityIdentification39 reqFinancialInstrumentIdentification )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_P-BGcZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification39 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the business error.
    /// </summary>
    [IsoId("_P-BGc5JKEeuAlLVx8pyt3w")]
    [DisplayName("Business Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizErr")]
    #endif
    [IsoXmlTag("BizErr")]
    public ErrorHandling5? BusinessError { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _P-BGc5JKEeuAlLVx8pyt3w
    
    
    #nullable disable
    
}
