﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResidenceTypeCode.  ISO2002 ID# _-WZTUGjMEeiRg5NzP0jkQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of residence where the party has its permanent home or principal establishment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-WZTUGjMEeiRg5NzP0jkQg")]
[Description(@"Specifies the type of residence where the party has its permanent home or principal establishment.")]
public enum ResidenceTypeCode
{
    /// <summary>
    /// Residence is domestic.
    /// Encoded/decoded by serializers as "DMST".
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_AyErkGjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is domestic.")]
    Domestic,
    
    /// <summary>
    /// Residence is foreign.
    /// Encoded/decoded by serializers as "FRGN".
    /// </summary>
    [EnumMember(Value = "FRGN")]
    [IsoId("_CC7PcGjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is foreign.")]
    Foreign,
    
    /// <summary>
    /// Residence is mixed
    /// Encoded/decoded by serializers as "MXED".
    /// </summary>
    [EnumMember(Value = "MXED")]
    [IsoId("_DKcRIGjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is mixed")]
    Mixed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResidenceTypeCodeMetadataExtensions
{
    private static readonly ResidenceTypeCodeDropdownSource _dropdownSource = new ResidenceTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResidenceTypeCodeDropdownRow GetMetadata(this ResidenceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


