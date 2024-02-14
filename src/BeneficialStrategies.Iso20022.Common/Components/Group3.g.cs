﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Group3.  ISO2002 ID# _D1xVkW49EeiU9cctagi5ow.
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
/// Group of parties with their related security certificate.
/// </summary>
[IsoId("_D1xVkW49EeiU9cctagi5ow")]
[DisplayName("Group")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Group3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Group3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Group3( System.String reqGroupIdentification )
    {
        GroupIdentification = reqGroupIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_D_AxIW49EeiU9cctagi5ow")]
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
    /// Specifies the identification of the group.
    /// </summary>
    [IsoId("_D_AxI249EeiU9cctagi5ow")]
    [DisplayName("Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpId")]
    #endif
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText GroupIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GroupIdentification { get; init; } 
    #else
    public System.String GroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a party and related certificate.
    /// </summary>
    [IsoId("_D_AxJW49EeiU9cctagi5ow")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    public PartyAndCertificate5? Party { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _D_AxJW49EeiU9cctagi5ow
    
    
    #nullable disable
    
}
