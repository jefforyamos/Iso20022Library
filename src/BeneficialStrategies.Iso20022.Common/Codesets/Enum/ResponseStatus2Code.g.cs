﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResponseStatus2Code.  ISO2002 ID# _DvI04Mf1EemlRYW9CHJ8_Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DvI04Mf1EemlRYW9CHJ8_Q")]
[Description(@"Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.")]
[DerivedFrom(typeof(ResponseStatusCode))]
public enum ResponseStatus2Code
{
    /// <summary>
    /// Collateral giver instruction details are confirmed.
    /// Encoded/decoded by serializers as "Confirmed".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_FtcUocf1EemlRYW9CHJ8_Q")]
    [Description(@"Collateral giver instruction details are confirmed.")]
    Confirmed,
    
    /// <summary>
    /// Collateral giver instruction details are not recognised.
    /// 
    /// Encoded/decoded by serializers as "NotRecognised".
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_Fzstocf1EemlRYW9CHJ8_Q")]
    [Description(@"Collateral giver instruction details are not recognised. ")]
    NotRecognised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResponseStatus2CodeMetadataExtensions
{
    private static readonly ResponseStatus2CodeDropdownSource _dropdownSource = new ResponseStatus2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponseStatus2CodeDropdownRow GetMetadata(this ResponseStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


