﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClearingMethodCode.  ISO2002 ID# _99IlkA8SEeSFHsNYty4C9Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the value is net (inclusive of tax) or gross.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_99IlkA8SEeSFHsNYty4C9Q")]
[Description(@"Specifies whether the value is net (inclusive of tax) or gross.")]
[Derivations(typeof(ClearingMethod1Code),typeof(ClearingMethod2Code))]
// External derivations that should be provided by the proper interface are: 
public enum ClearingMethodCode
{
    /// <summary>
    /// Settlement done by netting amounts (for trades in the same currency and for the same value date).
    /// Encoded/decoded by serializers as "NENE".
    /// </summary>
    [EnumMember(Value = "NENE")]
    [IsoId("_Gp_A8A8TEeSFHsNYty4C9Q")]
    [Description(@"Settlement done by netting amounts (for trades in the same currency and for the same value date).")]
    NetNegotiation,
    
    /// <summary>
    /// Each trade is settled by a single entry to the account of the beneficiary.
    /// Encoded/decoded by serializers as "GRNE".
    /// </summary>
    [EnumMember(Value = "GRNE")]
    [IsoId("_NDxNgA8TEeSFHsNYty4C9Q")]
    [Description(@"Each trade is settled by a single entry to the account of the beneficiary.")]
    GrossNegotiation,
    
    /// <summary>
    /// In a foreign exchange transaction, the third party as a central clearing counterparty will settle the transaction for both sides respectively.
    /// Encoded/decoded by serializers as "NEMA".
    /// </summary>
    [EnumMember(Value = "NEMA")]
    [IsoId("_Tjg4IA8TEeSFHsNYty4C9Q")]
    [Description(@"In a foreign exchange transaction, the third party as a central clearing counterparty will settle the transaction for both sides respectively.")]
    NetMatch,
    
    /// <summary>
    /// Day clearing.
    /// Encoded/decoded by serializers as "DAYC".
    /// </summary>
    [EnumMember(Value = "DAYC")]
    [IsoId("_sC6yNnx8EemHsOqJOzMVfg")]
    [Description(@"Day clearing.")]
    Day,
    
    /// <summary>
    /// Clearing to be deferred in time.
    /// Encoded/decoded by serializers as "DFRD".
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_sC6yN3x8EemHsOqJOzMVfg")]
    [Description(@"Clearing to be deferred in time.")]
    Deferred,
    
    /// <summary>
    /// Clearing for instant payments and transfers.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_sC6yOHx8EemHsOqJOzMVfg")]
    [Description(@"Clearing for instant payments and transfers.")]
    Instant,
    
    /// <summary>
    /// Other type of clearing method defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_sC6yOXx8EemHsOqJOzMVfg")]
    [Description(@"Other type of clearing method defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of clearing method defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_sC6yOnx8EemHsOqJOzMVfg")]
    [Description(@"Other type of clearing method defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Clearing done in real time.
    /// Encoded/decoded by serializers as "RLTM".
    /// </summary>
    [EnumMember(Value = "RLTM")]
    [IsoId("_sC6yO3x8EemHsOqJOzMVfg")]
    [Description(@"Clearing done in real time.")]
    RealTime,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClearingMethodCodeMetadataExtensions
{
    private static readonly ClearingMethodCodeDropdownSource _dropdownSource = new ClearingMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClearingMethodCodeDropdownRow GetMetadata(this ClearingMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


