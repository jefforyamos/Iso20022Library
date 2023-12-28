﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BestExecutionCode.  ISO2002 ID# _beXewtp-Ed-ak6NoX_4Aeg_-112393777.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether best execution rules as defined in the EU MiFID directive were followed for a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beXewtp-Ed-ak6NoX_4Aeg_-112393777")]
[Description(@"Specifies whether best execution rules as defined in the EU MiFID directive were followed for a transaction.")]
[Derivations(typeof(BestExecution1Code))]
// External derivations that should be provided by the proper interface are: 
public enum BestExecutionCode
{
    /// <summary>
    /// Best execution rules were followed.
    /// Encoded/decoded by serializers as "BTEX".
    /// </summary>
    [EnumMember(Value = "BTEX")]
    [IsoId("_beXew9p-Ed-ak6NoX_4Aeg_146193560")]
    [Description(@"Best execution rules were followed.")]
    Best,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BestExecutionCodeMetadataExtensions
{
    private static readonly BestExecutionCodeDropdownSource _dropdownSource = new BestExecutionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBestExecutionCodeDropdownRow GetMetadata(this BestExecutionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


