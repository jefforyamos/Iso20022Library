﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundLegalFormCode.  ISO2002 ID# _as4-htp-Ed-ak6NoX_4Aeg_-2143335309.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// The legal form of a Fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_as4-htp-Ed-ak6NoX_4Aeg_-2143335309")]
[Description(@"The legal form of a Fund.")]
public enum FundLegalFormCode
{
    /// <summary>
    /// The fund is constituted under the law of contract. Contractual fund issue units and investors are called unitholders. The fund is run by a management company which may or may not delegate to third agents certain investment and/or administration tasks.
    /// Encoded/decoded by serializers as "CONT".
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_as4-h9p-Ed-ak6NoX_4Aeg_-1270607029")]
    [Description(@"The fund is constituted under the law of contract. Contractual fund issue units and investors are called unitholders. The fund is run by a management company which may or may not delegate to third agents certain investment and/or administration tasks.")]
    Contractual,
    
    /// <summary>
    /// The fund is constituted under the trust law. Whereby an independant person (a trustee) holds the assets of the investment fund for the benefit of the underlying investors. The trustee is placed under the fiduciary responsibility to ensure that the fund is managed in accordance with its investment policy and objectives.
    /// Encoded/decoded by serializers as "TRUS".
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_as4-iNp-Ed-ak6NoX_4Aeg_-1157936958")]
    [Description(@"The fund is constituted under the trust law. Whereby an independant person (a trustee) holds the assets of the investment fund for the benefit of the underlying investors. The trustee is placed under the fiduciary responsibility to ensure that the fund is managed in accordance with its investment policy and objectives.")]
    Trust,
    
    /// <summary>
    /// The fund is constituted as a company. It issues shares and the investors are the shareholders. The fund is run by a management company which may or may not delegate to third agens certain investment and/or administration tasks.
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_atCvgNp-Ed-ak6NoX_4Aeg_472999748")]
    [Description(@"The fund is constituted as a company. It issues shares and the investors are the shareholders. The fund is run by a management company which may or may not delegate to third agens certain investment and/or administration tasks.")]
    Corporate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundLegalFormCodeMetadataExtensions
{
    private static readonly FundLegalFormCodeDropdownSource _dropdownSource = new FundLegalFormCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundLegalFormCodeDropdownRow GetMetadata(this FundLegalFormCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


