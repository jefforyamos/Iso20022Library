﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationRight1Code.  ISO2002 ID# _bYjKpdp-Ed-ak6NoX_4Aeg_-1019449690.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYjKpdp-Ed-ak6NoX_4Aeg_-1019449690")]
[Description(@"Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.")]
[DerivedFrom(typeof(CancellationRightCode))]
public enum CancellationRight1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Entitled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bYjKptp-Ed-ak6NoX_4Aeg_533511288")]
    [Description(@"??")]
    Entitled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExecutionOnly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bYjKp9p-Ed-ak6NoX_4Aeg_533511383")]
    [Description(@"??")]
    ExecutionOnly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WaiverAgreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bYjKqNp-Ed-ak6NoX_4Aeg_533511443")]
    [Description(@"??")]
    WaiverAgreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Institutional".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bYs7oNp-Ed-ak6NoX_4Aeg_533511503")]
    [Description(@"??")]
    Institutional,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationRight1CodeMetadataExtensions
{
    private static readonly CancellationRight1CodeDropdownSource _dropdownSource = new CancellationRight1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationRight1CodeDropdownRow GetMetadata(this CancellationRight1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


