﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationStatus4Code.  ISO2002 ID# _a0VqUNp-Ed-ak6NoX_4Aeg_434017571.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the cancellation request of an invoice financing request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0VqUNp-Ed-ak6NoX_4Aeg_434017571")]
[Description(@"Specifies the status of the cancellation request of an invoice financing request.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0VqUdp-Ed-ak6NoX_4Aeg_-927683854")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0VqUtp-Ed-ak6NoX_4Aeg_-831637751")]
    [Description(@"??")]
    Rejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationStatus4CodeMetadataExtensions
{
    private static readonly CancellationStatus4CodeDropdownSource _dropdownSource = new CancellationStatus4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationStatus4CodeDropdownRow GetMetadata(this CancellationStatus4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


