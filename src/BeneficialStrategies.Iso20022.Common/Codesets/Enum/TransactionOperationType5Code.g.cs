﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionOperationType5Code.  ISO2002 ID# _EQebAK1UEemkQYpo6COeTA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EQebAK1UEemkQYpo6COeTA")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeCode))]
public enum TransactionOperationType5Code
{
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as "NEWT".
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_HyDEUa1UEemkQYpo6COeTA")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction = TransactionOperationTypeCode.NewTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as "MODI".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_H8xtoa1UEemkQYpo6COeTA")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification = TransactionOperationTypeCode.Modification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.
    /// Encoded/decoded by serializers as "EROR".
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_IHqH8a1UEemkQYpo6COeTA")]
    [Description(@"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.")]
    Error = TransactionOperationTypeCode.Error, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an early termination.
    /// Encoded/decoded by serializers as "ETRM".
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_ISPnUa1UEemkQYpo6COeTA")]
    [Description(@"Transaction is an early termination.")]
    EarlyTermination = TransactionOperationTypeCode.EarlyTermination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as "CORR".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_IcXzsa1UEemkQYpo6COeTA")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction = TransactionOperationTypeCode.Correction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as "VALU".
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_Ivcgsa1UEemkQYpo6COeTA")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate = TransactionOperationTypeCode.ValuationUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as "POSC".
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_I5IoMa1UEemkQYpo6COeTA")]
    [Description(@"Contract to be reported as a new trade and included in a separate position report on the same day.")]
    PositionComponent = TransactionOperationTypeCode.PositionComponent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update of a contract collateral.
    /// Encoded/decoded by serializers as "COLU".
    /// </summary>
    [EnumMember(Value = "COLU")]
    [IsoId("_hZexga1UEemkQYpo6COeTA")]
    [Description(@"Update of a contract collateral.")]
    CollateralUpdate = TransactionOperationTypeCode.CollateralUpdate, // same ordinal as derivation source for type conversions
    
}
