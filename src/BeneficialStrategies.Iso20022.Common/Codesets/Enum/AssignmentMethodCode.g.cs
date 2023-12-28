﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssignmentMethodCode.  ISO2002 ID# _bfaAlNp-Ed-ak6NoX_4Aeg_-1937835864.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method under which assignment was conducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bfaAlNp-Ed-ak6NoX_4Aeg_-1937835864")]
[Description(@"Method under which assignment was conducted.")]
public enum AssignmentMethodCode
{
    /// <summary>
    /// Assignment was conducted randomly.
    /// Encoded/decoded by serializers as "RAND".
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_bfaAldp-Ed-ak6NoX_4Aeg_-1677400986")]
    [Description(@"Assignment was conducted randomly.")]
    Random,
    
    /// <summary>
    /// Assignment was conducted on a prorata basis.
    /// Encoded/decoded by serializers as "PROR".
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_bfaAltp-Ed-ak6NoX_4Aeg_-1652467505")]
    [Description(@"Assignment was conducted on a prorata basis.")]
    Prorata,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssignmentMethodCodeMetadataExtensions
{
    private static readonly AssignmentMethodCodeDropdownSource _dropdownSource = new AssignmentMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssignmentMethodCodeDropdownRow GetMetadata(this AssignmentMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


