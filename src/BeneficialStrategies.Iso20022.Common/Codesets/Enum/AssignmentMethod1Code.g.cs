﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssignmentMethod1Code.  ISO2002 ID# _bfaAkdp-Ed-ak6NoX_4Aeg_-1934141861.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method under which assignment was conducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bfaAkdp-Ed-ak6NoX_4Aeg_-1934141861")]
[Description(@"Method under which assignment was conducted.")]
[DerivedFrom(typeof(AssignmentMethodCode))]
public enum AssignmentMethod1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Random".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bfaAktp-Ed-ak6NoX_4Aeg_-1560115838")]
    [Description(@"??")]
    Random,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Prorata".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bfaAk9p-Ed-ak6NoX_4Aeg_-1560115837")]
    [Description(@"??")]
    Prorata,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssignmentMethod1CodeMetadataExtensions
{
    private static readonly AssignmentMethod1CodeDropdownSource _dropdownSource = new AssignmentMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssignmentMethod1CodeDropdownRow GetMetadata(this AssignmentMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


