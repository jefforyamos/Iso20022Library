﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HolderType1Code.  ISO2002 ID# _i8_PME4SEeiQHa-q1Uephw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of holder.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_i8_PME4SEeiQHa-q1Uephw")]
[Description(@"Specifies a type of holder.")]
[DerivedFrom(typeof(HolderTypeCode))]
public enum HolderType1Code
{
    /// <summary>
    /// Holder is the transferee party. The transferee party may also be known as the acquiring party.
    /// Encoded/decoded by serializers as "Transferee".
    /// </summary>
    [EnumMember(Value = "TFEE")]
    [IsoId("_nUYtQU4SEeiQHa-q1Uephw")]
    [Description(@"Holder is the transferee party. The transferee party may also be known as the acquiring party.")]
    Transferee,
    
    /// <summary>
    /// Holder is the transferor party. The transferee party may also be known as the ceding party.
    /// Encoded/decoded by serializers as "Transferor".
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_naLzQU4SEeiQHa-q1Uephw")]
    [Description(@"Holder is the transferor party. The transferee party may also be known as the ceding party.")]
    Transferor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class HolderType1CodeMetadataExtensions
{
    private static readonly HolderType1CodeDropdownSource _dropdownSource = new HolderType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHolderType1CodeDropdownRow GetMetadata(this HolderType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


