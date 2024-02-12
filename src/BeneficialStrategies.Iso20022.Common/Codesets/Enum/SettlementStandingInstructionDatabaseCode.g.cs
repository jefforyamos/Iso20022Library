﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementStandingInstructionDatabaseCode.  ISO2002 ID# _ZMVKstp-Ed-ak6NoX_4Aeg_-276633824.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMVKstp-Ed-ak6NoX_4Aeg_-276633824")]
[Description(@"Indicates what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.")]
[Derivations(typeof(SettlementStandingInstructionDatabase1Code))]
public enum SettlementStandingInstructionDatabaseCode
{
    /// <summary>
    /// The settlement standing instruction database to be used is the receiver's internal database.
    /// Encoded/decoded by serializers as "INTE".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZMVKs9p-Ed-ak6NoX_4Aeg_-390472890")]
    [Description(@"The settlement standing instruction database to be used is the receiver's internal database.")]
    InternalDatabase,
    
    /// <summary>
    /// The settlement standing instruction database to be used is the broker's database.
    /// Encoded/decoded by serializers as "BRKR".
    /// </summary>
    [EnumMember(Value = "BRKR")]
    [IsoId("_ZMVKtNp-Ed-ak6NoX_4Aeg_-1565663915")]
    [Description(@"The settlement standing instruction database to be used is the broker's database.")]
    BrokerDatabase,
    
    /// <summary>
    /// The settlement standing instruction database to be used is the database of the vendor.
    /// Encoded/decoded by serializers as "VEND".
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("_ZMVKtdp-Ed-ak6NoX_4Aeg_2024188766")]
    [Description(@"The settlement standing instruction database to be used is the database of the vendor.")]
    VendorDatabase,
    
}
