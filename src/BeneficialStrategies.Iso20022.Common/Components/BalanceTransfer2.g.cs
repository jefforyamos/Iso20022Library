﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceTransfer2.  ISO2002 ID# _6zmxjW48EeiU9cctagi5ow.
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
/// Information that enables any payments made in connection with the fulfilment of an account switch to be reconciled by the relevant account servicer with the associated request.
/// </summary>
[IsoId("_6zmxjW48EeiU9cctagi5ow")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Balance Transfer")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceTransfer2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that enables the creditor to reconcile a payment received through a different payment channel with the payment request.
    /// </summary>
    [IsoId("_68jSIW48EeiU9cctagi5ow")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Transfer Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceTransferReference1? BalanceTransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceTransferReference1? BalanceTransferReference { get; init; } 
    #else
    public BalanceTransferReference1? BalanceTransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Contains details of the clearance and settlement method chosen to make the appropriate payment from account servicer to account servicer in order to transfer the positive or negative closing balance of the old account to the new account.
    /// </summary>
    [IsoId("_68jSI248EeiU9cctagi5ow")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Transfer Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementMethod2Choice_? BalanceTransferMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementMethod2Choice_? BalanceTransferMethod { get; init; } 
    #else
    public SettlementMethod2Choice_? BalanceTransferMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum value that the new account servicer will pay to the old account servicer when the closing balance on the old account is negative.
    /// </summary>
    [IsoId("_68jSJW48EeiU9cctagi5ow")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Transfer Funding Limit")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; init; } 
    #else
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
