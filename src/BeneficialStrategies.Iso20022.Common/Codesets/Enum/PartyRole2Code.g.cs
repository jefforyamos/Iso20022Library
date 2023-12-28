﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyRole2Code.  ISO2002 ID# _kyRs4I6VEemzmeK8_tPygg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kyRs4I6VEemzmeK8_tPygg")]
[Description(@"Specifies the role of the party in the transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum PartyRole2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Distributor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nbvCcY6VEemzmeK8_tPygg")]
    [Description(@"??")]
    Distributor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LegalGuardian".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nzPjgo6VEemzmeK8_tPygg")]
    [Description(@"??")]
    LegalGuardian,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DecisionMaker".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pQEt4o6VEemzmeK8_tPygg")]
    [Description(@"??")]
    DecisionMaker,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyRole2CodeMetadataExtensions
{
    private static readonly PartyRole2CodeDropdownSource _dropdownSource = new PartyRole2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyRole2CodeDropdownRow GetMetadata(this PartyRole2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


