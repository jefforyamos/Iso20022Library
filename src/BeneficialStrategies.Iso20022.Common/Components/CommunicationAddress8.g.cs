﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommunicationAddress8.  ISO2002 ID# _jVS2x5lCEee-Zps0fZQaFQ.
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
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_jVS2x5lCEee-Zps0fZQaFQ")]
[DisplayName("Communication Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommunicationAddress8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommunicationAddress8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommunicationAddress8( LongPostalAddress1Choice_ reqPostalAddress,System.String reqPhoneNumber )
    {
        PostalAddress = reqPostalAddress;
        PhoneNumber = reqPhoneNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_jdVYcZlCEee-Zps0fZQaFQ")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LongPostalAddress1Choice_ PostalAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LongPostalAddress1Choice_ PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LongPostalAddress1Choice_ PostalAddress { get; init; } 
    #else
    public LongPostalAddress1Choice_ PostalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_jdVYc5lCEee-Zps0fZQaFQ")]
    [DisplayName("Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhneNb")]
    #endif
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPhoneNumber PhoneNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PhoneNumber { get; init; } 
    #else
    public System.String PhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_jdVYdZlCEee-Zps0fZQaFQ")]
    [DisplayName("Fax Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaxNb")]
    #endif
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? FaxNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FaxNumber { get; init; } 
    #else
    public System.String? FaxNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_jdVYd5lCEee-Zps0fZQaFQ")]
    [DisplayName("Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailAdr")]
    #endif
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? EmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmailAddress { get; init; } 
    #else
    public System.String? EmailAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
