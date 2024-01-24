﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalRight1Code.  ISO2002 ID# _bmjxdtp-Ed-ak6NoX_4Aeg_1174072380.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bmjxdtp-Ed-ak6NoX_4Aeg_1174072380")]
[Description(@"Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).")]
[DerivedFrom(typeof(AdditionalRightCode))]
public enum AdditionalRight1Code
{
    /// <summary>
    /// Defines a written question proposal.
    /// Encoded/decoded by serializers as "WQPS".
    /// </summary>
    [EnumMember(Value = "WQPS")]
    [IsoId("_bmjxd9p-Ed-ak6NoX_4Aeg_1593352605")]
    [Description(@"Defines a written question proposal.")]
    WrittenQuestionProposal = AdditionalRightCode.WrittenQuestionProposal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Defines a resolution proposal.
    /// Encoded/decoded by serializers as "RSPS".
    /// </summary>
    [EnumMember(Value = "RSPS")]
    [IsoId("_bmjxeNp-Ed-ak6NoX_4Aeg_1593352636")]
    [Description(@"Defines a resolution proposal.")]
    ResolutionProposal = AdditionalRightCode.ResolutionProposal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Defines a resolution proposal.
    /// Encoded/decoded by serializers as "AIPS".
    /// </summary>
    [EnumMember(Value = "AIPS")]
    [IsoId("_bmticNp-Ed-ak6NoX_4Aeg_1593352666")]
    [Description(@"Defines a resolution proposal.")]
    AgendaItemProposal = AdditionalRightCode.AgendaItemProposal, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalRight1CodeMetadataExtensions
{
    private static readonly AdditionalRight1CodeDropdownSource _dropdownSource = new AdditionalRight1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalRight1CodeDropdownRow GetMetadata(this AdditionalRight1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


