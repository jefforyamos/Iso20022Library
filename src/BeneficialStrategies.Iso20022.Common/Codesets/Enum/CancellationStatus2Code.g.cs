﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationStatus2Code.  ISO2002 ID# _bYs7p9p-Ed-ak6NoX_4Aeg_-1025146236.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYs7p9p-Ed-ak6NoX_4Aeg_-1025146236")]
[Description(@"Specifies the cancellation status.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus2Code
{
    /// <summary>
    /// Cancellation instruction/request has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as "SentToNextParty".
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_bYs7qNp-Ed-ak6NoX_4Aeg_-1024226245")]
    [Description(@"Cancellation instruction/request has been sent to the next party, that is, the next intermediary.")]
    SentToNextParty,
    
    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bY2soNp-Ed-ak6NoX_4Aeg_-1024226221")]
    [Description(@"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.")]
    Accepted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationStatus2CodeMetadataExtensions
{
    private static readonly CancellationStatus2CodeDropdownSource _dropdownSource = new CancellationStatus2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationStatus2CodeDropdownRow GetMetadata(this CancellationStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


