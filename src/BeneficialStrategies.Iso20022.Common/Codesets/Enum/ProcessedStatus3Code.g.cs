﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProcessedStatus3Code.  ISO2002 ID# _aKeN-Np-Ed-ak6NoX_4Aeg_969222817.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status of an advice, a request or a movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKeN-Np-Ed-ak6NoX_4Aeg_969222817")]
[Description(@"Specifies the processing status of an advice, a request or a movement.")]
[DerivedFrom(typeof(CorporateActionProcessedStatusCode))]
public enum ProcessedStatus3Code
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aKnX4Np-Ed-ak6NoX_4Aeg_-807236817")]
    [Description(@"The instruction/request has been received.")]
    Received,
    
    /// <summary>
    /// The processing of the request is pending.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_aKnX4dp-Ed-ak6NoX_4Aeg_-807236816")]
    [Description(@"The processing of the request is pending.")]
    Pending,
    
    /// <summary>
    /// The request is accepted.
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aKnX4tp-Ed-ak6NoX_4Aeg_-807236786")]
    [Description(@"The request is accepted.")]
    Accepted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProcessedStatus3CodeMetadataExtensions
{
    private static readonly ProcessedStatus3CodeDropdownSource _dropdownSource = new ProcessedStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProcessedStatus3CodeDropdownRow GetMetadata(this ProcessedStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


