﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementStandingInstructionDatabase1Code.  ISO2002 ID# _ZMMAxtp-Ed-ak6NoX_4Aeg_-1452828987.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMMAxtp-Ed-ak6NoX_4Aeg_-1452828987")]
[Description(@"Indicates what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.")]
[DerivedFrom(typeof(SettlementStandingInstructionDatabaseCode))]
public enum SettlementStandingInstructionDatabase1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InternalDatabase".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZMMAx9p-Ed-ak6NoX_4Aeg_-774171757")]
    [Description(@"??")]
    InternalDatabase,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BrokerDatabase".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZMVKsNp-Ed-ak6NoX_4Aeg_-371277985")]
    [Description(@"??")]
    BrokerDatabase,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VendorDatabase".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZMVKsdp-Ed-ak6NoX_4Aeg_-1645817532")]
    [Description(@"??")]
    VendorDatabase,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementStandingInstructionDatabase1CodeMetadataExtensions
{
    private static readonly SettlementStandingInstructionDatabase1CodeDropdownSource _dropdownSource = new SettlementStandingInstructionDatabase1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementStandingInstructionDatabase1CodeDropdownRow GetMetadata(this SettlementStandingInstructionDatabase1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

