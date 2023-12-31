﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementDate1Code.  ISO2002 ID# _ZK_t9tp-Ed-ak6NoX_4Aeg_581713028.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the date of settlement in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZK_t9tp-Ed-ak6NoX_4Aeg_581713028")]
[Description(@"Indicates the date of settlement in coded form.")]
[DerivedFrom(typeof(SettlementDateCode))]
public enum SettlementDate1Code
{
    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// Encoded/decoded by serializers as "AsSoonAsPossible".
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_ZK_t99p-Ed-ak6NoX_4Aeg_581713029")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    AsSoonAsPossible,
    
    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// Encoded/decoded by serializers as "AtEndOfContract".
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_ZK_t-Np-Ed-ak6NoX_4Aeg_581713038")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    AtEndOfContract,
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// Encoded/decoded by serializers as "WhenAndIfIssued".
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_ZLI34Np-Ed-ak6NoX_4Aeg_-732074064")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WhenAndIfIssued,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementDate1CodeMetadataExtensions
{
    private static readonly SettlementDate1CodeDropdownSource _dropdownSource = new SettlementDate1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementDate1CodeDropdownRow GetMetadata(this SettlementDate1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


