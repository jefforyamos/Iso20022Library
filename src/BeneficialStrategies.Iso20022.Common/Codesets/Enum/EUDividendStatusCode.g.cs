﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EUDividendStatusCode.  ISO2002 ID# _aiKVONp-Ed-ak6NoX_4Aeg_235937580.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aiKVONp-Ed-ak6NoX_4Aeg_235937580")]
[Description(@"Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments.")]
[Derivations(typeof(EUDividendStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum EUDividendStatusCode
{
    /// <summary>
    /// Dividend is in the scope of the directive.
    /// Encoded/decoded by serializers as "DIVI".
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_aiUGMNp-Ed-ak6NoX_4Aeg_-1873978987")]
    [Description(@"Dividend is in the scope of the directive.")]
    DividendInScope,
    
    /// <summary>
    /// Dividend is out of the scope of the directive.
    /// Encoded/decoded by serializers as "DIVO".
    /// </summary>
    [EnumMember(Value = "DIVO")]
    [IsoId("_aiUGMdp-Ed-ak6NoX_4Aeg_-1873978970")]
    [Description(@"Dividend is out of the scope of the directive.")]
    DividendOutScope,
    
    /// <summary>
    /// Unknown whether the dividend is in or out of the scope of the directive.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aiUGMtp-Ed-ak6NoX_4Aeg_-1873978935")]
    [Description(@"Unknown whether the dividend is in or out of the scope of the directive.")]
    DividendUnknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EUDividendStatusCodeMetadataExtensions
{
    private static readonly EUDividendStatusCodeDropdownSource _dropdownSource = new EUDividendStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEUDividendStatusCodeDropdownRow GetMetadata(this EUDividendStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


