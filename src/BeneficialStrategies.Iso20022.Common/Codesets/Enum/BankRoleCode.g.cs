﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BankRoleCode.  ISO2002 ID# _yh4FcNNsEeKdOs2hjJ_3WQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the bank in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yh4FcNNsEeKdOs2hjJ_3WQ")]
[Description(@"Specifies the role of the bank in the transaction.")]
[Derivations(typeof(BankRole1Code))]
public enum BankRoleCode
{
    /// <summary>
    /// Bank of the buyer.
    /// Encoded/decoded by serializers as "BUYB".
    /// </summary>
    [EnumMember(Value = "BUYB")]
    [IsoId("_4OpbANNsEeKdOs2hjJ_3WQ")]
    [Description(@"Bank of the buyer.")]
    BuyersBank,
    
    /// <summary>
    /// Bank of the seller.
    /// Encoded/decoded by serializers as "SELB".
    /// </summary>
    [EnumMember(Value = "SELB")]
    [IsoId("__ov1ENNsEeKdOs2hjJ_3WQ")]
    [Description(@"Bank of the seller.")]
    SellersBank,
    
    /// <summary>
    /// Obligor bank.
    /// Encoded/decoded by serializers as "OBLB".
    /// </summary>
    [EnumMember(Value = "OBLB")]
    [IsoId("_CXLxQNNtEeKdOs2hjJ_3WQ")]
    [Description(@"Obligor bank.")]
    ObligorBank,
    
    /// <summary>
    /// Recipient bank.
    /// Encoded/decoded by serializers as "RECB".
    /// </summary>
    [EnumMember(Value = "RECB")]
    [IsoId("_FYWcMNNtEeKdOs2hjJ_3WQ")]
    [Description(@"Recipient bank.")]
    RecipientBank,
    
}
