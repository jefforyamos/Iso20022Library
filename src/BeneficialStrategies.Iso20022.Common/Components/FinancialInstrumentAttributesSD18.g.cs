﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributesSD18.  ISO2002 ID# _sDR-Ab-3Eeeb2ZBoAlSG1Q.
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
/// Provides additional information regarding security that will be distributed as part of entitlement.
/// </summary>
[IsoId("_sDR-Ab-3Eeeb2ZBoAlSG1Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financial Instrument Attributes SD")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Security identification of the security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_sTNQYb-3Eeeb2ZBoAlSG1Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Declared Disbursed Security Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification20? DeclaredDisbursedSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20? DeclaredDisbursedSecurityIdentification { get; init; } 
    #else
    public SecurityIdentification20? DeclaredDisbursedSecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Declared disbursed security description.
    /// </summary>
    [IsoId("_sTNQab-3Eeeb2ZBoAlSG1Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Declared Disbursed Security Description")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? DeclaredDisbursedSecurityDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclaredDisbursedSecurityDescription { get; init; } 
    #else
    public System.String? DeclaredDisbursedSecurityDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
