﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TMSContactLevel1Code.  ISO2002 ID# _TUAMNQEcEeCQm6a_G2yO_w_-248608949.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Level of urgency in contacting the terminal management system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUAMNQEcEeCQm6a_G2yO_w_-248608949")]
[Description(@"Level of urgency in contacting the terminal management system.")]
[DerivedFrom(typeof(TMSContactLevelCode))]
public enum TMSContactLevel1Code
{
    /// <summary>
    /// Terminal management system has to be contacted before the next transaction.
    /// Encoded/decoded by serializers as "CRIT".
    /// </summary>
    [EnumMember(Value = "CRIT")]
    [IsoId("_TUAMNgEcEeCQm6a_G2yO_w_-1249727148")]
    [Description(@"Terminal management system has to be contacted before the next transaction.")]
    Critical = TMSContactLevelCode.Critical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Terminal management system has to be contacted as soon as possible (for example after reconciliation).
    /// Encoded/decoded by serializers as "ASAP".
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_TUAMNwEcEeCQm6a_G2yO_w_-1944834992")]
    [Description(@"Terminal management system has to be contacted as soon as possible (for example after reconciliation).")]
    AsSoonAsPossible = TMSContactLevelCode.AsSoonAsPossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Terminal management system has to be contacted at the date and time provided.
    /// Encoded/decoded by serializers as "DTIM".
    /// </summary>
    [EnumMember(Value = "DTIM")]
    [IsoId("_TUAMOAEcEeCQm6a_G2yO_w_2032355643")]
    [Description(@"Terminal management system has to be contacted at the date and time provided.")]
    DateTime = TMSContactLevelCode.DateTime, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TMSContactLevel1CodeMetadataExtensions
{
    private static readonly TMSContactLevel1CodeDropdownSource _dropdownSource = new TMSContactLevel1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITMSContactLevel1CodeDropdownRow GetMetadata(this TMSContactLevel1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


