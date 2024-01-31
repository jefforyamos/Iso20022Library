﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SWIFTServiceLevel2Code.  ISO2002 ID# _ZRGV9Np-Ed-ak6NoX_4Aeg_1129333378.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code identifying which SWIFT service level applies to the payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZRGV9Np-Ed-ak6NoX_4Aeg_1129333378")]
[Description(@"Code identifying which SWIFT service level applies to the payment instruction.")]
[DerivedFrom(typeof(SWIFTServiceLevelCode))]
public enum SWIFTServiceLevel2Code
{
    /// <summary>
    /// Credit transfer is to be processed according to the SWIFTPay Service Level.
    /// Encoded/decoded by serializers as "SPAY".
    /// </summary>
    [EnumMember(Value = "SPAY")]
    [IsoId("_ZRGV9dp-Ed-ak6NoX_4Aeg_1129333388")]
    [Description(@"Credit transfer is to be processed according to the SWIFTPay Service Level.")]
    SWIFTPay = SWIFTServiceLevelCode.SWIFTPay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transfer is to be processed according to the Standard Service Level.
    /// Encoded/decoded by serializers as "SSTD".
    /// </summary>
    [EnumMember(Value = "SSTD")]
    [IsoId("_ZRGV9tp-Ed-ak6NoX_4Aeg_1129333389")]
    [Description(@"Credit transfer is to be processed according to the Standard Service Level.")]
    Standard = SWIFTServiceLevelCode.Standard, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SWIFTServiceLevel2CodeMetadataExtensions
{
    private static readonly SWIFTServiceLevel2CodeDropdownSource _dropdownSource = new SWIFTServiceLevel2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISWIFTServiceLevel2CodeDropdownRow GetMetadata(this SWIFTServiceLevel2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


