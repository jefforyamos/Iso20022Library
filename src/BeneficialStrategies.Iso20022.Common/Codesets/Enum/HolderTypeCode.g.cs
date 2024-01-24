﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HolderTypeCode.  ISO2002 ID# _KdDVkE4SEeiQHa-q1Uephw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of holder.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KdDVkE4SEeiQHa-q1Uephw")]
[Description(@"Specifies a type of holder.")]
[Derivations(typeof(HolderType1Code))]
public enum HolderTypeCode
{
    /// <summary>
    /// Holder is the transferee party. The transferee party may also be known as the acquiring party.
    /// Encoded/decoded by serializers as "TFEE".
    /// </summary>
    [EnumMember(Value = "TFEE")]
    [IsoId("_Ni66UE4SEeiQHa-q1Uephw")]
    [Description(@"Holder is the transferee party. The transferee party may also be known as the acquiring party.")]
    Transferee,
    
    /// <summary>
    /// Holder is the transferor party. The transferee party may also be known as the ceding party.
    /// Encoded/decoded by serializers as "TFOR".
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_SpoVcE4SEeiQHa-q1Uephw")]
    [Description(@"Holder is the transferor party. The transferee party may also be known as the ceding party.")]
    Transferor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class HolderTypeCodeMetadataExtensions
{
    private static readonly HolderTypeCodeDropdownSource _dropdownSource = new HolderTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHolderTypeCodeDropdownRow GetMetadata(this HolderTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


