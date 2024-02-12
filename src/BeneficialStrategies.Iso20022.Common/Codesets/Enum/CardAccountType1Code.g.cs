﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardAccountType1Code.  ISO2002 ID# _TSNcfAEcEeCQm6a_G2yO_w_389240327.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cardholder account used for the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSNcfAEcEeCQm6a_G2yO_w_389240327")]
[Description(@"Type of cardholder account used for the transaction.")]
[DerivedFrom(typeof(CardAccountTypeCode))]
public enum CardAccountType1Code
{
    /// <summary>
    /// Default account.
    /// Encoded/decoded by serializers as "DFLT".
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_TSNcfQEcEeCQm6a_G2yO_w_-449669424")]
    [Description(@"Default account.")]
    Default = CardAccountTypeCode.Default, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Savings account.
    /// Encoded/decoded by serializers as "SVNG".
    /// </summary>
    [EnumMember(Value = "SVNG")]
    [IsoId("_TSNcfgEcEeCQm6a_G2yO_w_1127404324")]
    [Description(@"Savings account.")]
    Savings = CardAccountTypeCode.Savings, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Checking account.
    /// Encoded/decoded by serializers as "CHCK".
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_TSNcfwEcEeCQm6a_G2yO_w_1944410752")]
    [Description(@"Checking account.")]
    Checking = CardAccountTypeCode.Checking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit card account.
    /// Encoded/decoded by serializers as "CRDT".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_TSNcgAEcEeCQm6a_G2yO_w_-2082317872")]
    [Description(@"Credit card account.")]
    CreditCard = CardAccountTypeCode.CreditCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Universal account.
    /// Encoded/decoded by serializers as "UVRL".
    /// </summary>
    [EnumMember(Value = "UVRL")]
    [IsoId("_TSNcgQEcEeCQm6a_G2yO_w_-469218526")]
    [Description(@"Universal account.")]
    Universal = CardAccountTypeCode.Universal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account.
    /// Encoded/decoded by serializers as "INVS".
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_TSNcggEcEeCQm6a_G2yO_w_2114733823")]
    [Description(@"Investment account.")]
    Investment = CardAccountTypeCode.Investment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic purse card account.
    /// Encoded/decoded by serializers as "EPRS".
    /// </summary>
    [EnumMember(Value = "EPRS")]
    [IsoId("_TSXNcAEcEeCQm6a_G2yO_w_-304672763")]
    [Description(@"Electronic purse card account.")]
    EpurseCard = CardAccountTypeCode.EpurseCard, // same ordinal as derivation source for type conversions
    
}
