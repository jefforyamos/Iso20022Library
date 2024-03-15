﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MerchantToken1.  ISO2002 ID# _iSpH0C5GEeunNvJlR_vCbg.
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
/// Merchant token information.
/// </summary>
[IsoId("_iSpH0C5GEeunNvJlR_vCbg")]
[DisplayName("Merchant Token")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MerchantToken1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Surrogate value of the PAN.
    /// </summary>
    [IsoId("_xwQFWS5GEeunNvJlR_vCbg")]
    [DisplayName("Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tkn")]
    #endif
    [IsoXmlTag("Tkn")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin8Max28NumericText? Token { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Token { get; init; } 
    #else
    public System.String? Token { get; set; } 
    #endif
    
    /// <summary>
    /// Expiration date of the payment token that is generated by and maintained in the token vault.
    /// </summary>
    [IsoId("_xwQFWy5GEeunNvJlR_vCbg")]
    [DisplayName("Token Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknXpryDt")]
    #endif
    [IsoXmlTag("TknXpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? TokenExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenExpiryDate { get; init; } 
    #else
    public System.String? TokenExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional payment token information.
    /// </summary>
    [IsoId("_xwQFXC5GEeunNvJlR_vCbg")]
    [DisplayName("Token Characteristic")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknChrtc")]
    #endif
    [IsoXmlTag("TknChrtc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TokenCharacteristic { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenCharacteristic { get; init; } 
    #else
    public System.String? TokenCharacteristic { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of a token provider requestor.
    /// </summary>
    [IsoId("_xwQFXS5GEeunNvJlR_vCbg")]
    [DisplayName("Token Requestor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknRqstr")]
    #endif
    [IsoXmlTag("TknRqstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTokenIdentifiers1? TokenRequestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTokenIdentifiers1? TokenRequestor { get; init; } 
    #else
    public PaymentTokenIdentifiers1? TokenRequestor { get; set; } 
    #endif
    
    /// <summary>
    /// Level of confidence resulting of the identification and authentication of the cardholder performed and the entity that performed it.
    /// </summary>
    [IsoId("_xwQFXi5GEeunNvJlR_vCbg")]
    [DisplayName("Token Assurance Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknAssrncLvl")]
    #endif
    [IsoXmlTag("TknAssrncLvl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TokenAssuranceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TokenAssuranceLevel { get; init; } 
    #else
    public System.UInt64? TokenAssuranceLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the identification and verification of the cardholder.
    /// </summary>
    [IsoId("_xwQFXy5GEeunNvJlR_vCbg")]
    [DisplayName("Token Assurance Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknAssrncData")]
    #endif
    [IsoXmlTag("TknAssrncData")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Binary? TokenAssuranceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TokenAssuranceData { get; init; } 
    #else
    public System.Byte[]? TokenAssuranceData { get; set; } 
    #endif
    
    /// <summary>
    /// Value that allows a Token Service Provider to indicate the identification and verification performed representing the binding of the payment token to the underlying PAN and cardholder.
    /// </summary>
    [IsoId("_xwQFYC5GEeunNvJlR_vCbg")]
    [DisplayName("Token Assurance Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknAssrncMtd")]
    #endif
    [IsoXmlTag("TknAssrncMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenAssuranceMethod { get; init; } 
    #else
    public System.String? TokenAssuranceMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Original transaction was initiated by Token.
    /// </summary>
    [IsoId("_xwQFYS5GEeunNvJlR_vCbg")]
    [DisplayName("Token Initiated Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknInittdInd")]
    #endif
    [IsoXmlTag("TknInittdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TokenInitiatedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenInitiatedIndicator { get; init; } 
    #else
    public System.String? TokenInitiatedIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
