﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralTransactionType1Code.  ISO2002 ID# _zKAQULyzEeivTd4NUfCi2g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral instruction as a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zKAQULyzEeivTd4NUfCi2g")]
[Description(@"Specifies the type of collateral instruction as a code.")]
[DerivedFrom(typeof(CollateralTransactionTypeCode))]
public enum CollateralTransactionType1Code
{
    /// <summary>
    /// Automatic/manual settlement adjustment to change the allocation mode from manual to automatic or vice  versa.
    /// Encoded/decoded by serializers as "AADJ".
    /// </summary>
    [EnumMember(Value = "AADJ")]
    [IsoId("_4oc2AbyzEeivTd4NUfCi2g")]
    [Description(@"Automatic/manual settlement adjustment to change the allocation mode from manual to automatic or vice  versa.")]
    AllocationModeAdjustment = CollateralTransactionTypeCode.AllocationModeAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change of the closing date.
    /// Encoded/decoded by serializers as "CDTA".
    /// </summary>
    [EnumMember(Value = "CDTA")]
    [IsoId("_43ILMryzEeivTd4NUfCi2g")]
    [Description(@"Change of the closing date.")]
    ClosingDateAdjustment = CollateralTransactionTypeCode.ClosingDateAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change to collateral. Used  when collateral giver manually allocates the securities to the transaction.
    /// Encoded/decoded by serializers as "CADJ".
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_45Er8byzEeivTd4NUfCi2g")]
    [Description(@"Change to collateral. Used  when collateral giver manually allocates the securities to the transaction.")]
    CollateralAdjustment = CollateralTransactionTypeCode.CollateralAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change of other data.
    /// Encoded/decoded by serializers as "DADJ".
    /// </summary>
    [EnumMember(Value = "DADJ")]
    [IsoId("_4_4ekbyzEeivTd4NUfCi2g")]
    [Description(@"Change of other data.")]
    DataAdjustment = CollateralTransactionTypeCode.DataAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery by value (DBV) transaction. 
    /// Encoded/decoded by serializers as "DBVT".
    /// </summary>
    [EnumMember(Value = "DBVT")]
    [IsoId("_5F4Y4byzEeivTd4NUfCi2g")]
    [Description(@"Delivery by value (DBV) transaction. |")]
    DeliveredByValue = CollateralTransactionTypeCode.DeliveredByValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creation of a Collateral Management Transaction.
    /// Encoded/decoded by serializers as "INIT".
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_5PiEIryzEeivTd4NUfCi2g")]
    [Description(@"Creation of a Collateral Management Transaction.")]
    Initiation = CollateralTransactionTypeCode.Initiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change to margin. 
    /// Encoded/decoded by serializers as "MADJ".
    /// </summary>
    [EnumMember(Value = "MADJ")]
    [IsoId("_5V-qYbyzEeivTd4NUfCi2g")]
    [Description(@"Change to margin. |")]
    MarginAdjustment = CollateralTransactionTypeCode.MarginAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change of principal/exposure adjustment
    /// Encoded/decoded by serializers as "PADJ".
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_5g6vEryzEeivTd4NUfCi2g")]
    [Description(@"Change of principal/exposure adjustment")]
    PrincipalExposureAdjustment = CollateralTransactionTypeCode.PrincipalExposureAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change of rate.
    /// Encoded/decoded by serializers as "RATA".
    /// </summary>
    [EnumMember(Value = "RATA")]
    [IsoId("_5o_tAbyzEeivTd4NUfCi2g")]
    [Description(@"Change of rate.")]
    RateAdjustment = CollateralTransactionTypeCode.RateAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Closing of the Collateral Management Transaction.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_51DMAryzEeivTd4NUfCi2g")]
    [Description(@"Closing of the Collateral Management Transaction.")]
    Termination = CollateralTransactionTypeCode.Termination, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralTransactionType1CodeMetadataExtensions
{
    private static readonly CollateralTransactionType1CodeDropdownSource _dropdownSource = new CollateralTransactionType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralTransactionType1CodeDropdownRow GetMetadata(this CollateralTransactionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


