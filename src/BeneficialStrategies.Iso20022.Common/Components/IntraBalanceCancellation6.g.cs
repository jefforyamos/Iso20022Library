﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraBalanceCancellation6.  ISO2002 ID# _qIqm7znfEem7JZMuWtwtsg.
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
/// Provides the details of the cancellation requests.
/// </summary>
[IsoId("_qIqm7znfEem7JZMuWtwtsg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Intra Balance Cancellation")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalanceCancellation6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraBalanceCancellation6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalanceCancellation6( System.String reqRequestReference )
    {
        RequestReference = reqRequestReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_qSppUznfEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount38? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38? CashAccount { get; init; } 
    #else
    public CashAccount38? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_qSppUTnfEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Account Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    #else
    public SystemPartyIdentification8? CashAccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_MpzYETqCEemJ3KLLPeYl6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Account Servicer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_qSppVTnfEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus69Choice_? ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus69Choice_? ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus69Choice_? ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the cancellation request.
    /// </summary>
    [IsoId("_qSppXTnfEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Request Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RequestReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String RequestReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequestReference { get; init; } 
    #else
    public System.String RequestReference { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_qSppXznfEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StatusDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StatusDate { get; init; } 
    #else
    public System.DateTime? StatusDate { get; set; } 
    #endif
    
    /// <summary>
    /// References of the transaction for which the intra-balance modification is requested.
    /// </summary>
    [IsoId("_qSppZznfEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public References14? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References14? TransactionIdentification { get; init; } 
    #else
    public References14? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies additional details of the transaction.
    /// </summary>
    [IsoId("_qSppbznfEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Underlying Intra Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IntraBalance5? UnderlyingIntraBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraBalance5? UnderlyingIntraBalance { get; init; } 
    #else
    public IntraBalance5? UnderlyingIntraBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
