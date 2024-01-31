﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProposalTypeCode.  ISO2002 ID# _YdGGJtp-Ed-ak6NoX_4Aeg_1195947295.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proposal is an initial or a counter proposal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YdGGJtp-Ed-ak6NoX_4Aeg_1195947295")]
[Description(@"Specifies whether the proposal is an initial or a counter proposal.")]
[Derivations(typeof(ProposalType1Code))]
public enum ProposalTypeCode
{
    /// <summary>
    /// Specifies this is an initial proposal.
    /// Encoded/decoded by serializers as "INIT".
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_YdGGJ9p-Ed-ak6NoX_4Aeg_1552099762")]
    [Description(@"Specifies this is an initial proposal.")]
    Initial,
    
    /// <summary>
    /// Specifies this is a counter proposal.
    /// Encoded/decoded by serializers as "COUN".
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_YdGGKNp-Ed-ak6NoX_4Aeg_917818427")]
    [Description(@"Specifies this is a counter proposal.")]
    Counter,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProposalTypeCodeMetadataExtensions
{
    private static readonly ProposalTypeCodeDropdownSource _dropdownSource = new ProposalTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProposalTypeCodeDropdownRow GetMetadata(this ProposalTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


