﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LevelOfControl1Code.  ISO2002 ID# _kcJ1ICDDEeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of control.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kcJ1ICDDEeWPMvNwVtiMsA")]
[Description(@"Specifies the level of control.")]
[DerivedFrom(typeof(LevelOfControlCode))]
public enum LevelOfControl1Code
{
    /// <summary>
    /// Transactions are permitted on the account.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_mhS8sSDDEeWPMvNwVtiMsA")]
    [Description(@"Transactions are permitted on the account.")]
    Transactions = LevelOfControlCode.Transactions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account may be viewed only.
    /// Encoded/decoded by serializers as "VIEW".
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_mpeoUSDDEeWPMvNwVtiMsA")]
    [Description(@"Account may be viewed only.")]
    View = LevelOfControlCode.View, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LevelOfControl1CodeMetadataExtensions
{
    private static readonly LevelOfControl1CodeDropdownSource _dropdownSource = new LevelOfControl1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILevelOfControl1CodeDropdownRow GetMetadata(this LevelOfControl1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


