﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesSettlementStatus1Code.  ISO2002 ID# _ZFx2xdp-Ed-ak6NoX_4Aeg_1485379028.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of settlement of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFx2xdp-Ed-ak6NoX_4Aeg_1485379028")]
[Description(@"Provides the status of settlement of an instruction.")]
[DerivedFrom(typeof(SecuritiesSettlementStatusCode))]
public enum SecuritiesSettlementStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZFx2xtp-Ed-ak6NoX_4Aeg_1558336292")]
    [Description(@"??")]
    Pending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Failing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZFx2x9p-Ed-ak6NoX_4Aeg_1570340511")]
    [Description(@"??")]
    Failing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesSettlementStatus1CodeMetadataExtensions
{
    private static readonly SecuritiesSettlementStatus1CodeDropdownSource _dropdownSource = new SecuritiesSettlementStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesSettlementStatus1CodeDropdownRow GetMetadata(this SecuritiesSettlementStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


