﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestigatedParties1Code.  ISO2002 ID# _U1p9sGKEEeG1ab6Vf7EgPA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigated parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U1p9sGKEEeG1ab6Vf7EgPA")]
[Description(@"Specifies the investigated parties.")]
[DerivedFrom(typeof(InvestigatedPartiesCode))]
public enum InvestigatedParties1Code
{
    /// <summary>
    /// Investigated parties are all parties playig a role matching the search criteria.
    /// Encoded/decoded by serializers as "ALLP".
    /// </summary>
    [EnumMember(Value = "ALLP")]
    [IsoId("_XhTElmKEEeG1ab6Vf7EgPA")]
    [Description(@"Investigated parties are all parties playig a role matching the search criteria.")]
    AllParties = InvestigatedPartiesCode.AllParties, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investigated party is the owner.
    /// Encoded/decoded by serializers as "OWNE".
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_XmNZxmKEEeG1ab6Vf7EgPA")]
    [Description(@"Investigated party is the owner.")]
    Owner = InvestigatedPartiesCode.Owner, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestigatedParties1CodeMetadataExtensions
{
    private static readonly InvestigatedParties1CodeDropdownSource _dropdownSource = new InvestigatedParties1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestigatedParties1CodeDropdownRow GetMetadata(this InvestigatedParties1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


