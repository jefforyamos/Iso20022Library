﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InformationTypeCode.  ISO2002 ID# _aWsFAtp-Ed-ak6NoX_4Aeg_760507288.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the coded type of additional information provided.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWsFAtp-Ed-ak6NoX_4Aeg_760507288")]
[Description(@"Specifies the coded type of additional information provided.")]
[Derivations(typeof(InformationType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum InformationTypeCode
{
    /// <summary>
    /// Instructions used to ease automatic request processing.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_aWsFA9p-Ed-ak6NoX_4Aeg_1218573157")]
    [Description(@"Instructions used to ease automatic request processing.")]
    ProcessingInstructions,
    
    /// <summary>
    /// Instructions used to ease automatic request relay.
    /// Encoded/decoded by serializers as "RELY".
    /// </summary>
    [EnumMember(Value = "RELY")]
    [IsoId("_aWsFBNp-Ed-ak6NoX_4Aeg_1222266779")]
    [Description(@"Instructions used to ease automatic request relay.")]
    RelayInstructions,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InformationTypeCodeMetadataExtensions
{
    private static readonly InformationTypeCodeDropdownSource _dropdownSource = new InformationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInformationTypeCodeDropdownRow GetMetadata(this InformationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


