﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AmountConsistencyType1Code.  ISO2002 ID# _QjU6UAStEeusZ4O-nsxv_w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of amount inconsistencies, that the amount type provided matches the reference amount or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QjU6UAStEeusZ4O-nsxv_w")]
[Description(@"Specifies a type of amount inconsistencies, that the amount type provided matches the reference amount or not.")]
[DerivedFrom(typeof(AmountConsistencyTypeCode))]
public enum AmountConsistencyType1Code
{
    /// <summary>
    /// Amount information matches the reference data record.
    /// Encoded/decoded by serializers as "CONS".
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_TnhrIQStEeusZ4O-nsxv_w")]
    [Description(@"Amount information matches the reference data record.")]
    ConsistentAmount = AmountConsistencyTypeCode.ConsistentAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount information does not match the reference data record.
    /// Encoded/decoded by serializers as "ICNS".
    /// </summary>
    [EnumMember(Value = "ICNS")]
    [IsoId("_TtTjAQStEeusZ4O-nsxv_w")]
    [Description(@"Amount information does not match the reference data record.")]
    InconsistentAmount = AmountConsistencyTypeCode.InconsistentAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges amount information does not match the reference data record.
    /// Encoded/decoded by serializers as "ICGA".
    /// </summary>
    [EnumMember(Value = "ICGA")]
    [IsoId("_TxnbQQStEeusZ4O-nsxv_w")]
    [Description(@"Charges amount information does not match the reference data record.")]
    InconsistentChargesAmount = AmountConsistencyTypeCode.InconsistentChargesAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount information confirmed to the creditor does not match the reference data record.
    /// Encoded/decoded by serializers as "ICFA".
    /// </summary>
    [EnumMember(Value = "ICFA")]
    [IsoId("_T26K8QStEeusZ4O-nsxv_w")]
    [Description(@"Amount information confirmed to the creditor does not match the reference data record.")]
    InconsistentConfirmedAmount = AmountConsistencyTypeCode.InconsistentConfirmedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interbank settlement amount information does not match the reference data record.
    /// Encoded/decoded by serializers as "IISA".
    /// </summary>
    [EnumMember(Value = "IISA")]
    [IsoId("_T8DJoQStEeusZ4O-nsxv_w")]
    [Description(@"Interbank settlement amount information does not match the reference data record.")]
    InconsistentInterbankSettlementAmount = AmountConsistencyTypeCode.InconsistentInterbankSettlementAmount, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AmountConsistencyType1CodeMetadataExtensions
{
    private static readonly AmountConsistencyType1CodeDropdownSource _dropdownSource = new AmountConsistencyType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAmountConsistencyType1CodeDropdownRow GetMetadata(this AmountConsistencyType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


