﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalParameters30.  ISO2002 ID# _DbrtYY7DEeaa5_S8lsRKCQ.
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
/// Specifies additional parameters to the message or transaction.
/// </summary>
[IsoId("_DbrtYY7DEeaa5_S8lsRKCQ")]
[DisplayName("Additional Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalParameters30
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether there exists a pre-confirmation.
    /// </summary>
    [IsoId("_Dqj24Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Pre Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreConf")]
    #endif
    [IsoXmlTag("PreConf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreConfirmation1Code? PreConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreConfirmation1Code? PreConfirmation { get; init; } 
    #else
    public PreConfirmation1Code? PreConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    [IsoId("_Dqj26Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Partial Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlSttlm")]
    #endif
    [IsoXmlTag("PrtlSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartialSettlement2Code? PartialSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartialSettlement2Code? PartialSettlement { get; init; } 
    #else
    public PartialSettlement2Code? PartialSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent&apos;s/service-provider&apos;s point of view.
    /// </summary>
    [IsoId("_Dqj28Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtSvcPrvdrCollTxId")]
    #endif
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? TripartyAgentServiceProviderCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("_Dqj2-Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntTrptyCollTxId")]
    #endif
    [IsoXmlTag("ClntTrptyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientTripartyCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? ClientTripartyCollateralTransactionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
