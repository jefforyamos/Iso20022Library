﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyConversion25.  ISO2002 ID# _7I6bMVE4EeyApZmLzm74zA.
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
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider.
/// </summary>
[IsoId("_7I6bMVE4EeyApZmLzm74zA")]
[DisplayName("Currency Conversion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyConversion25
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyConversion25 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyConversion25( CurrencyConversionResponse3Code reqResult )
    {
        Result = reqResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    [IsoId("_7PCRUVE4EeyApZmLzm74zA")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyConversionResponse3Code Result { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyConversionResponse3Code Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversionResponse3Code Result { get; init; } 
    #else
    public CurrencyConversionResponse3Code Result { get; set; } 
    #endif
    
    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    [IsoId("_7PCRU1E4EeyApZmLzm74zA")]
    [DisplayName("Result Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltRsn")]
    #endif
    [IsoXmlTag("RsltRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ResultReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResultReason { get; init; } 
    #else
    public System.String? ResultReason { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the conversion of currency.
    /// </summary>
    [IsoId("_7PCRVVE4EeyApZmLzm74zA")]
    [DisplayName("Conversion Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsDtls")]
    #endif
    [IsoXmlTag("ConvsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion23? ConversionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion23? ConversionDetails { get; init; } 
    #else
    public CurrencyConversion23? ConversionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
