﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PledgeeTypeCode.  ISO2002 ID# _fynYkE9ZEeSn2-3swbRbzg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pledgee.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fynYkE9ZEeSn2-3swbRbzg")]
[Description(@"Specifies the type of pledgee.")]
[Derivations(typeof(PledgeeType1Code))]
public enum PledgeeTypeCode
{
    /// <summary>
    /// Financial instruments are pledged to a regulatory body.
    /// Encoded/decoded by serializers as "REGB".
    /// </summary>
    [EnumMember(Value = "REGB")]
    [IsoId("_J-JKME9aEeSn2-3swbRbzg")]
    [Description(@"Financial instruments are pledged to a regulatory body.")]
    RegulatoryBody,
    
    /// <summary>
    /// Financial instruments are pledged to a counterparty.
    /// Encoded/decoded by serializers as "CPTY".
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_0CJM8E9ZEeSn2-3swbRbzg")]
    [Description(@"Financial instruments are pledged to a counterparty.")]
    Counterparty,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PledgeeTypeCodeMetadataExtensions
{
    private static readonly PledgeeTypeCodeDropdownSource _dropdownSource = new PledgeeTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPledgeeTypeCodeDropdownRow GetMetadata(this PledgeeTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


