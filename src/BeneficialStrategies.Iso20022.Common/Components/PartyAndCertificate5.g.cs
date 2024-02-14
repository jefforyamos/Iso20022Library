﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyAndCertificate5.  ISO2002 ID# _D_AxJ249EeiU9cctagi5ow.
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
/// Party and related security certificate.
/// </summary>
[IsoId("_D_AxJ249EeiU9cctagi5ow")]
[DisplayName("Party And Certificate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyAndCertificate5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyAndCertificate5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyAndCertificate5( PartyIdentification135 reqParty )
    {
        Party = reqParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_ELOoMW49EeiU9cctagi5ow")]
    [DisplayName("Modification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModCd")]
    #endif
    [IsoXmlTag("ModCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Modification1Code? ModificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Modification1Code? ModificationCode { get; init; } 
    #else
    public Modification1Code? ModificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_ELOoM249EeiU9cctagi5ow")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification135 Party { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification135 Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135 Party { get; init; } 
    #else
    public PartyIdentification135 Party { get; set; } 
    #endif
    
    /// <summary>
    /// Security certificate used to sign electronically.
    /// </summary>
    [IsoId("_ELOoNW49EeiU9cctagi5ow")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Certificate { get; init; } 
    #else
    public System.Byte[]? Certificate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
