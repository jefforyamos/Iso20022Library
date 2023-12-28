﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ConfirmationTypeCode.  ISO2002 ID# _VqbxQdp-Ed-ak6NoX_4Aeg_-1345554396.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VqbxQdp-Ed-ak6NoX_4Aeg_-1345554396")]
[Description(@"Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.")]
[Derivations(typeof(ConfirmationType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ConfirmationTypeCode
{
    /// <summary>
    /// Specifies that the confirmation is an intention to execute a transfer instruction for the listed assets.
    /// Encoded/decoded by serializers as "INTT".
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_VqbxQtp-Ed-ak6NoX_4Aeg_-1318772467")]
    [Description(@"Specifies that the confirmation is an intention to execute a transfer instruction for the listed assets.")]
    Intent,
    
    /// <summary>
    /// Specifies that the message is an actual confirmation of the execution of a transfer request.
    /// Encoded/decoded by serializers as "ACTL".
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_VqbxQ9p-Ed-ak6NoX_4Aeg_887847604")]
    [Description(@"Specifies that the message is an actual confirmation of the execution of a transfer request.")]
    Actual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ConfirmationTypeCodeMetadataExtensions
{
    private static readonly ConfirmationTypeCodeDropdownSource _dropdownSource = new ConfirmationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IConfirmationTypeCodeDropdownRow GetMetadata(this ConfirmationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


