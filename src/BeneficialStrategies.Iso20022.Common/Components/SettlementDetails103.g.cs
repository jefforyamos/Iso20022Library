﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails103.  ISO2002 ID# _5TJ-V5NLEeWGlc8L7oPDIg.
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
/// Details of settlement of a transaction.
/// </summary>
[IsoId("_5TJ-V5NLEeWGlc8L7oPDIg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Settlement Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDetails103
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_5TJ-W5NLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Transaction Condition")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition21Choice_? SettlementTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition21Choice_? SettlementTransactionCondition { get; init; } 
    #else
    public SettlementTransactionCondition21Choice_? SettlementTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_5TJ-Y5NLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Registration")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Registration11Choice_? Registration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Registration11Choice_? Registration { get; init; } 
    #else
    public Registration11Choice_? Registration { get; set; } 
    #endif
    
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_5TJ-a5NLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Legal Restrictions")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Restriction6Choice_? LegalRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Restriction6Choice_? LegalRestrictions { get; init; } 
    #else
    public Restriction6Choice_? LegalRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_5TJ-c5NLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities RTGS")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; } 
    #else
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_5TJ-e5NLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement System Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; } 
    #else
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_5TJ-g5NLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Capacity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; } 
    #else
    public TaxCapacityParty5Choice_? TaxCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_5TJ-i5NLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Stamp Duty Tax Basis")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification47? StampDutyTaxBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification47? StampDutyTaxBasis { get; init; } 
    #else
    public GenericIdentification47? StampDutyTaxBasis { get; set; } 
    #endif
    
    
    #nullable disable
    
}
