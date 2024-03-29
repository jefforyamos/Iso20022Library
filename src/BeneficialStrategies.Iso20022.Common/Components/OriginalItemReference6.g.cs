﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalItemReference6.  ISO2002 ID# _b9qOodcZEeqRFcf2R4bPBw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Provides further means of referencing a payment transaction.
/// </summary>
[IsoId("_b9qOodcZEeqRFcf2R4bPBw")]
[DisplayName("Original Item Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalItemReference6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_cBVNodcZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? Account { get; init; } 
    #else
    public CashAccount40? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_cBVNo9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? AccountOwner { get; init; } 
    #else
    public Party40Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_cBVNpdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_cBVNp9cZEeqRFcf2R4bPBw")]
    [DisplayName("Related Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdAcct")]
    #endif
    [IsoXmlTag("RltdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? RelatedAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? RelatedAccount { get; init; } 
    #else
    public CashAccount40? RelatedAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_cBVNqdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? Debtor { get; init; } 
    #else
    public Party40Choice_? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_cBVNq9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_cBVNrdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt")]
    #endif
    [IsoXmlTag("IntrmyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_cBVNr9cZEeqRFcf2R4bPBw")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Purpose2Choice_? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Purpose2Choice_? Purpose { get; init; } 
    #else
    public Purpose2Choice_? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_cBVNsdcZEeqRFcf2R4bPBw")]
    [DisplayName("Related Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRmtInf")]
    #endif
    [IsoXmlTag("RltdRmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceLocation7? RelatedRemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceLocation7? RelatedRemittanceInformation { get; init; } 
    #else
    public RemittanceLocation7? RelatedRemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_cBVNs9cZEeqRFcf2R4bPBw")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation21? RemittanceInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
