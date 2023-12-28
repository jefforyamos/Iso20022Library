﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Reporting3Code.  ISO2002 ID# _4mWQgNB4EeihG9bKfarOOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies to which institution the reporting must be done.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4mWQgNB4EeihG9bKfarOOA")]
[Description(@"Identifies to which institution the reporting must be done.")]
[DerivedFrom(typeof(ReportingCode))]
public enum Reporting3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyIn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7EMzAdB4EeihG9bKfarOOA")]
    [Description(@"??")]
    BuyIn,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeferredReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7Nt7YdB4EeihG9bKfarOOA")]
    [Description(@"??")]
    DeferredReport,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegulatoryOrganisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7UkKQdB4EeihG9bKfarOOA")]
    [Description(@"??")]
    RegulatoryOrganisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StockExchange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7a9GIdB4EeihG9bKfarOOA")]
    [Description(@"??")]
    StockExchange,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Reporting3CodeMetadataExtensions
{
    private static readonly Reporting3CodeDropdownSource _dropdownSource = new Reporting3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReporting3CodeDropdownRow GetMetadata(this Reporting3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


