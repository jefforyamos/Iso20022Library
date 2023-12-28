﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReconciliationType1Code.  ISO2002 ID# _a7zFENxeEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of Reconciliation requested by the Sale to the POI.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7zFENxeEeioifFt1dhnJA")]
[Description(@"Type of Reconciliation requested by the Sale to the POI.")]
[DerivedFrom(typeof(ReconciliationTypeCode))]
public enum ReconciliationType1Code
{
    /// <summary>
    /// Reconciliation between the POI and one or several Acquirers only. There is no reconciliation between the Sale System and the POI System.
    /// Encoded/decoded by serializers as "AcquirerReconciliation".
    /// </summary>
    [EnumMember(Value = "AREC")]
    [IsoId("_czip0dxeEeioifFt1dhnJA")]
    [Description(@"Reconciliation between the POI and one or several Acquirers only. There is no reconciliation between the Sale System and the POI System.")]
    AcquirerReconciliation,
    
    /// <summary>
    /// Reconciliation and closure of the current period, with synchronisation of the reconciliation between the POI and Acquirers.
    /// Encoded/decoded by serializers as "AcquirerSynchronisation".
    /// </summary>
    [EnumMember(Value = "ASYN")]
    [IsoId("_c2J48dxeEeioifFt1dhnJA")]
    [Description(@"Reconciliation and closure of the current period, with synchronisation of the reconciliation between the POI and Acquirers.")]
    AcquirerSynchronisation,
    
    /// <summary>
    /// Request result of a previous reconciliation.
    /// Encoded/decoded by serializers as "PreviousReconciliation".
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_c5ZaMdxeEeioifFt1dhnJA")]
    [Description(@"Request result of a previous reconciliation.")]
    PreviousReconciliation,
    
    /// <summary>
    /// Reconciliation with closure of the current period, without	any Acquirers synchronisation.
    /// Encoded/decoded by serializers as "SaleReconciliation".
    /// </summary>
    [EnumMember(Value = "SREC")]
    [IsoId("_c9mkwdxeEeioifFt1dhnJA")]
    [Description(@"Reconciliation with closure of the current period, without	any Acquirers synchronisation.")]
    SaleReconciliation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReconciliationType1CodeMetadataExtensions
{
    private static readonly ReconciliationType1CodeDropdownSource _dropdownSource = new ReconciliationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReconciliationType1CodeDropdownRow GetMetadata(this ReconciliationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


