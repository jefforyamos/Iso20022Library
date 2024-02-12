﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteMethods3.  ISO2002 ID# _MPdpxa4jEemG7MmivSuE5g.
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
/// Information about the vote methods to be used.
/// </summary>
[IsoId("_MPdpxa4jEemG7MmivSuE5g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Vote Methods")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteMethods3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    [IsoId("_Mm0Z064jEemG7MmivSuE5g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Vote Through Network")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    public SimpleValueList<System.String> VoteThroughNetwork { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Address where the voting ballot can be sent.
    /// </summary>
    [IsoId("_Mm0Z1a4jEemG7MmivSuE5g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Vote By Mail")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    public ValueList<PostalAddress1> VoteByMail { get; init; } = new ValueList<PostalAddress1>(){};
    
    /// <summary>
    /// Electronic address, e-mail or web site, where a security holder can vote.
    /// </summary>
    [IsoId("_Mm0Z164jEemG7MmivSuE5g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Electronic Vote")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    public ValueList<CommunicationAddress11> ElectronicVote { get; init; } = new ValueList<CommunicationAddress11>(){};
    
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_Mm0Z2a4jEemG7MmivSuE5g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Vote By Telephone")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    public SimpleValueList<System.String> VoteByTelephone { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
