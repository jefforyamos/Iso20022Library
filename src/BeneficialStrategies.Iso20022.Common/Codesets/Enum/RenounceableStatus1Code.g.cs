﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RenounceableStatus1Code.  ISO2002 ID# _ZshGqNp-Ed-ak6NoX_4Aeg_-603219895.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the renounceable status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZshGqNp-Ed-ak6NoX_4Aeg_-603219895")]
[Description(@"Specifies the renounceable status.")]
[DerivedFrom(typeof(RenounceableStatusCode))]
public enum RenounceableStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonRenounceable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zsq3oNp-Ed-ak6NoX_4Aeg_-603219863")]
    [Description(@"??")]
    NonRenounceable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Renounceable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zsq3odp-Ed-ak6NoX_4Aeg_-603219862")]
    [Description(@"??")]
    Renounceable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RenounceableStatus1CodeMetadataExtensions
{
    private static readonly RenounceableStatus1CodeDropdownSource _dropdownSource = new RenounceableStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRenounceableStatus1CodeDropdownRow GetMetadata(this RenounceableStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

