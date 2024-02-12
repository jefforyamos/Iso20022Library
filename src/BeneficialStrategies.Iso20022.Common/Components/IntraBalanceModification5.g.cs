﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraBalanceModification5.  ISO2002 ID# _Z496lTneEem7JZMuWtwtsg.
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
/// Provides the modification requests data in the report.
/// </summary>
[IsoId("_Z496lTneEem7JZMuWtwtsg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Intra Balance Modification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalanceModification5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_aD2U6TneEem7JZMuWtwtsg")]
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
    [IsoId("_aD2U5zneEem7JZMuWtwtsg")]
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
    [IsoId("_ik5TMTp-EemwKdP955WBJQ")]
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
    [IsoId("_aD2U6zneEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus71Choice_? ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus71Choice_? ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus71Choice_? ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the individual intrabalance modification transaction.
    /// </summary>
    [IsoId("_aD2U7TneEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Modification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public IntraBalanceModification6? Modification { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _aD2U7TneEem7JZMuWtwtsg
    
    
    #nullable disable
    
}
