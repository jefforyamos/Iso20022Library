﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Member6.  ISO2002 ID# _W1ihMXSeEeiH1ZOt2UD8vQ.
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
/// Information about the members of a system.
/// </summary>
[IsoId("_W1ihMXSeEeiH1ZOt2UD8vQ")]
[DisplayName("Member")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Member6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example, returns or rejects.
    /// </summary>
    [IsoId("_XBEbwXSeEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Return Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbRtrAdr")]
    #endif
    [IsoXmlTag("MmbRtrAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MemberIdentification3Choice_? MemberReturnAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberIdentification3Choice_? MemberReturnAddress { get; init; } 
    #else
    public MemberIdentification3Choice_? MemberReturnAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in a given organisation.
    /// </summary>
    [IsoId("_XBEbw3SeEeiH1ZOt2UD8vQ")]
    [DisplayName("Contact Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctRef")]
    #endif
    [IsoXmlTag("CtctRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentificationAndAddress1? ContactReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentificationAndAddress1? ContactReference { get; init; } 
    #else
    public ContactIdentificationAndAddress1? ContactReference { get; set; } 
    #endif
    
    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    [IsoId("_XBEbxXSeEeiH1ZOt2UD8vQ")]
    [DisplayName("Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComAdr")]
    #endif
    [IsoXmlTag("ComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress8? CommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress8? CommunicationAddress { get; init; } 
    #else
    public CommunicationAddress8? CommunicationAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
