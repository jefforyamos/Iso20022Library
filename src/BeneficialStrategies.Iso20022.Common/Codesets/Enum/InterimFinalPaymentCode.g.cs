﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterimFinalPaymentCode.  ISO2002 ID# _1orVsTL3EeKU9IrkkToqcw_-1263884737.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies payment type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1orVsTL3EeKU9IrkkToqcw_-1263884737")]
[Description(@"Specifies payment type.")]
public enum InterimFinalPaymentCode
{
    /// <summary>
    /// Interim payment. Pending possible future payments.
    /// Encoded/decoded by serializers as "INTE".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_1orVsjL3EeKU9IrkkToqcw_241333812")]
    [Description(@"Interim payment. Pending possible future payments.")]
    Interim,
    
    /// <summary>
    /// Final payment positions will be debited.
    /// Encoded/decoded by serializers as "FINL".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_1orVszL3EeKU9IrkkToqcw_731384259")]
    [Description(@"Final payment positions will be debited.")]
    Final,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InterimFinalPaymentCodeMetadataExtensions
{
    private static readonly InterimFinalPaymentCodeDropdownSource _dropdownSource = new InterimFinalPaymentCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInterimFinalPaymentCodeDropdownRow GetMetadata(this InterimFinalPaymentCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


