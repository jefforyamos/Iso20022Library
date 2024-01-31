﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SWIFTServiceLevelCode.  ISO2002 ID# _ZRGV99p-Ed-ak6NoX_4Aeg_1129333396.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the SWIFT service level that applies to the payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZRGV99p-Ed-ak6NoX_4Aeg_1129333396")]
[Description(@"Specifies the SWIFT service level that applies to the payment instruction.")]
[Derivations(typeof(SWIFTServiceLevel2Code))]
public enum SWIFTServiceLevelCode
{
    /// <summary>
    /// Credit transfer is to be processed according to the SWIFTPay Service Level.
    /// Encoded/decoded by serializers as "SPAY".
    /// </summary>
    [EnumMember(Value = "SPAY")]
    [IsoId("_ZRGV-Np-Ed-ak6NoX_4Aeg_1129333404")]
    [Description(@"Credit transfer is to be processed according to the SWIFTPay Service Level.")]
    SWIFTPay,
    
    /// <summary>
    /// Credit transfer is to be processed according to the Priority Service Level.
    /// Encoded/decoded by serializers as "SPRI".
    /// </summary>
    [EnumMember(Value = "SPRI")]
    [IsoId("_ZRQG8Np-Ed-ak6NoX_4Aeg_1129333405")]
    [Description(@"Credit transfer is to be processed according to the Priority Service Level.")]
    Priority,
    
    /// <summary>
    /// Credit transfer is to be processed according to the Standard Service Level.
    /// Encoded/decoded by serializers as "SSTD".
    /// </summary>
    [EnumMember(Value = "SSTD")]
    [IsoId("_ZRQG8dp-Ed-ak6NoX_4Aeg_1129333422")]
    [Description(@"Credit transfer is to be processed according to the Standard Service Level.")]
    Standard,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SWIFTServiceLevelCodeMetadataExtensions
{
    private static readonly SWIFTServiceLevelCodeDropdownSource _dropdownSource = new SWIFTServiceLevelCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISWIFTServiceLevelCodeDropdownRow GetMetadata(this SWIFTServiceLevelCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


