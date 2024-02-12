﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cardholder15.  ISO2002 ID# _91eHMEarEeeIjf8aP9KbJA.
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
/// Unprotected sensitive detailed information about the cardholder.
/// </summary>
[IsoId("_91eHMEarEeeIjf8aP9KbJA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cardholder")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cardholder15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the registered cardholder name that issuer knows to be correct.
    /// </summary>
    [IsoId("_Ozg8sEasEeeIjf8aP9KbJA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cardholder Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderName1? CardholderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderName1? CardholderName { get; init; } 
    #else
    public CardholderName1? CardholderName { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cardholder.
    /// ISO 8583:87 bit 56 (TLV tag 03/dataset 73)
    /// ISO 8583:93 bit 112 (TLV tag 03/dataset 73)
    /// ISO 8583:2003 bit 51 (TLV tag 03/dataset 73)
    /// </summary>
    [IsoId("_Wy6cMEasEeeIjf8aP9KbJA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Credentials1? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Credentials1? Identification { get; init; } 
    #else
    public Credentials1? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Complete address of the cardholder.
    /// </summary>
    [IsoId("_mALlsEauEeeIjf8aP9KbJA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? Address { get; init; } 
    #else
    public Address1? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Contact information.
    /// ISO 8583:87 bit 56 (TLV tag 02/dataset 72)
    /// ISO 8583:93 bit 112 (TLV tag 02/dataset 72)
    /// ISO 8583:2003 bit 51 (TLV tag 02/dataset 72)
    /// </summary>
    [IsoId("_VXD3MJjHEeeMBq7G6mQ32Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Contact Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact1? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact1? ContactInformation { get; init; } 
    #else
    public Contact1? ContactInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("_ZM4VARqYEeqH1IQNpbVpEw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date Of Birth")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfBirth { get; init; } 
    #else
    public System.DateOnly? DateOfBirth { get; set; } 
    #endif
    
    
    #nullable disable
    
}
