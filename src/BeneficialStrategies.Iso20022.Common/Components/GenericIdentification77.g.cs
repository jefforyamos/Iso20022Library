﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification77.  ISO2002 ID# _wVGBgYnzEeS9F4Qrq_eaVA.
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
/// Identification of an entity.
/// </summary>
[IsoId("_wVGBgYnzEeS9F4Qrq_eaVA")]
[DisplayName("Generic Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GenericIdentification77
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GenericIdentification77 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GenericIdentification77( System.String reqIdentification,PartyType12Code reqType )
    {
        Identification = reqIdentification;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_wh5ucYnzEeS9F4Qrq_eaVA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_wh5uc4nzEeS9F4Qrq_eaVA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyType12Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyType12Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType12Code Type { get; init; } 
    #else
    public PartyType12Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_wh5udYnzEeS9F4Qrq_eaVA")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType12Code? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType12Code? Issuer { get; init; } 
    #else
    public PartyType12Code? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_wh5ud4nzEeS9F4Qrq_eaVA")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3AlphaText? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Country { get; init; } 
    #else
    public System.String? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_wh5ueYnzEeS9F4Qrq_eaVA")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
