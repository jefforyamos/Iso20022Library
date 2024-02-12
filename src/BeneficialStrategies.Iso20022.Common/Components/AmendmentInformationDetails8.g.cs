﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmendmentInformationDetails8.  ISO2002 ID# _teX5FFkyEeGeoaLUQk__nA_528536611.
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
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_teX5FFkyEeGeoaLUQk__nA_528536611")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Amendment Information Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmendmentInformationDetails8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_tehqEFkyEeGeoaLUQk__nA_670667391")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Mandate Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalMandateIdentification { get; init; } 
    #else
    public System.String? OriginalMandateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_tehqEVkyEeGeoaLUQk__nA_1004495065")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Creditor Scheme Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_tehqElkyEeGeoaLUQk__nA_-488026944")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Creditor Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_tehqE1kyEeGeoaLUQk__nA_-499125721")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Creditor Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? OriginalCreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? OriginalCreditorAgentAccount { get; init; } 
    #else
    public CashAccount24? OriginalCreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_tehqFFkyEeGeoaLUQk__nA_-174008214")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Debtor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? OriginalDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? OriginalDebtor { get; init; } 
    #else
    public PartyIdentification43? OriginalDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_teq0AFkyEeGeoaLUQk__nA_1785884717")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Debtor Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    #else
    public CashAccount24? OriginalDebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_teq0AVkyEeGeoaLUQk__nA_2024930314")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Debtor Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_teq0AlkyEeGeoaLUQk__nA_2013831537")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Debtor Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? OriginalDebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? OriginalDebtorAgentAccount { get; init; } 
    #else
    public CashAccount24? OriginalDebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_teq0A1kyEeGeoaLUQk__nA_-2076799323")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Final Collection Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OriginalFinalCollectionDate { get; init; } 
    #else
    public System.DateOnly? OriginalFinalCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_teq0BFkyEeGeoaLUQk__nA_-1622712054")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Frequency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency6Code? OriginalFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency6Code? OriginalFrequency { get; init; } 
    #else
    public Frequency6Code? OriginalFrequency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
