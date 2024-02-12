﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardholderAuthentication13.  ISO2002 ID# _-PhO4QxuEeqdx6buGpCCQw.
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
/// Data related to the authentication of the cardholder.
/// </summary>
[IsoId("_-PhO4QxuEeqdx6buGpCCQw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cardholder Authentication")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderAuthentication13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_-bf1YQxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authentication Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; } 
    #else
    public AuthenticationMethod8Code? AuthenticationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// If Strong Customer Authentication is not mandated to process the transaction, this message element must identify the reason of exemption.
    /// </summary>
    [IsoId("_2jG4oAx1Eeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authentication Exemption")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Exemption1Code? AuthenticationExemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Exemption1Code? AuthenticationExemption { get; init; } 
    #else
    public Exemption1Code? AuthenticationExemption { get; set; } 
    #endif
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_-bf1YwxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authentication Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AuthenticationValue { get; init; } 
    #else
    public System.Byte[]? AuthenticationValue { get; set; } 
    #endif
    
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_-bf1ZQxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protected Authentication Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType22? ProtectedAuthenticationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType22? ProtectedAuthenticationValue { get; init; } 
    #else
    public ContentInformationType22? ProtectedAuthenticationValue { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_-bf1ZwxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cardholder On Line PIN")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLinePIN7? CardholderOnLinePIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLinePIN7? CardholderOnLinePIN { get; init; } 
    #else
    public OnLinePIN7? CardholderOnLinePIN { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    [IsoId("_-bf1aQxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cardholder Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonIdentification15? CardholderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentification15? CardholderIdentification { get; init; } 
    #else
    public PersonIdentification15? CardholderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric characters of the cardholder's billing or shipping address for verification.
    /// </summary>
    [IsoId("_-bf1awxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Address Verification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressVerification1? AddressVerification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressVerification1? AddressVerification { get; init; } 
    #else
    public AddressVerification1? AddressVerification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of authentication for a given method - e.g. three-domain authentication, scheme-proprietary authentication, etc.
    /// </summary>
    [IsoId("_-bf1bQxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authentication Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AuthenticationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationType { get; init; } 
    #else
    public System.String? AuthenticationType { get; set; } 
    #endif
    
    /// <summary>
    /// Level of authentication for a given type – e.g. value assigned by scheme rules or by bilateral agreements.
    /// </summary>
    [IsoId("_-bf1bwxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authentication Level")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AuthenticationLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationLevel { get; init; } 
    #else
    public System.String? AuthenticationLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Result of authentication.
    /// </summary>
    [IsoId("_-bf1cQxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authentication Result")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationResult1Code? AuthenticationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationResult1Code? AuthenticationResult { get; init; } 
    #else
    public AuthenticationResult1Code? AuthenticationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the result of the authentication.
    /// </summary>
    [IsoId("_-bf1cwxuEeqdx6buGpCCQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authentication Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternallyDefinedData1? AuthenticationAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternallyDefinedData1? AuthenticationAdditionalInformation { get; init; } 
    #else
    public ExternallyDefinedData1? AuthenticationAdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
