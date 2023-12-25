﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ForeignCurrencyPaymentElectionCode.  ISO2002 ID# _1zjwBDL3EeKU9IrkkToqcw_-811455456.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the foreign currency payment is offered.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1zjwBDL3EeKU9IrkkToqcw_-811455456")]
[Description(@"Specifies whether the foreign currency payment is offered.")]
public enum ForeignCurrencyPaymentElectionCode
{
    /// <summary>
    /// Foreign currency payment is offered.
    /// </summary>
    [EnumMember(Value = "OFFD")]
    [IsoId("_1zjwBTL3EeKU9IrkkToqcw_-225470944")]
    [Description(@"Foreign currency payment is offered.")]
    OFFD,
    
    /// <summary>
    /// Foreign currency payment is not offered.
    /// </summary>
    [EnumMember(Value = "NOFD")]
    [IsoId("_1zs58DL3EeKU9IrkkToqcw_123403253")]
    [Description(@"Foreign currency payment is not offered.")]
    NOFD,
    
    /// <summary>
    /// Foreign currency payment is mandatory.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_1zs58TL3EeKU9IrkkToqcw_325823435")]
    [Description(@"Foreign currency payment is mandatory.")]
    MAND,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ForeignCurrencyPaymentElectionCodeMetadataExtensions
{
    private static readonly ForeignCurrencyPaymentElectionCodeDropdownSource _dropdownSource = new ForeignCurrencyPaymentElectionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IForeignCurrencyPaymentElectionCodeDropdownRow GetMetadata(this ForeignCurrencyPaymentElectionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


