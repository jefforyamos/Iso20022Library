﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesSettlementStatus3Code.  ISO2002 ID# _WfglwMX-EeiSF9q-coWegA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of settlement of an instruction expressed as a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WfglwMX-EeiSF9q-coWegA")]
[Description(@"Provides the status of settlement of an instruction expressed as a code.")]
[DerivedFrom(typeof(SecuritiesSettlementStatusCode))]
public enum SecuritiesSettlementStatus3Code
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_YKVI0cX-EeiSF9q-coWegA")]
    [Description(@"Instruction is pending. Settlement at the instructed settlement date is still possible.")]
    Pending,
    
    /// <summary>
    /// Full settlement.
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_YSXqgcX-EeiSF9q-coWegA")]
    [Description(@"Full settlement.")]
    Settled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesSettlementStatus3CodeMetadataExtensions
{
    private static readonly SecuritiesSettlementStatus3CodeDropdownSource _dropdownSource = new SecuritiesSettlementStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesSettlementStatus3CodeDropdownRow GetMetadata(this SecuritiesSettlementStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


