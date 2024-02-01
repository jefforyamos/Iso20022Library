﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceInquiryResponse1.  ISO2002 ID# _XCUYcO19Eei-V5h0ja04AA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Balance Inquiry Response message.
/// </summary>
public partial record BalanceInquiryResponse1
{
    #nullable enable
    
    /// <summary>
    /// Payment account information.
    /// </summary>
    public PaymentAccount2? PaymentAccount { get; init; } 
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    public LoyaltyAccount1? LoyaltyAccount { get; init; } 
    /// <summary>
    /// Stored value account information.
    /// </summary>
    public StoredValueAccount1[] StoredValueAccount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    public PaymentReceipt1[] Receipt { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
