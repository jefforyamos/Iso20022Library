﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CILPaymentType1Code.  ISO2002 ID# _1s_1BjL3EeKU9IrkkToqcw_1334650704.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cash in lieu payment type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1s_1BjL3EeKU9IrkkToqcw_1334650704")]
[Description(@"Specifies the cash in lieu payment type.")]
[DerivedFrom(typeof(CILPaymentTypeCode))]
public enum CILPaymentType1Code
{
    /// <summary>
    /// Event pays daily at fixed rate.
    /// Encoded/decoded by serializers as "FIXD".
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_1tJmADL3EeKU9IrkkToqcw_1674898907")]
    [Description(@"Event pays daily at fixed rate.")]
    Fixed = CILPaymentTypeCode.Fixed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price can fluctuate. Payment is held until released.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_1tJmATL3EeKU9IrkkToqcw_1955757868")]
    [Description(@"Price can fluctuate. Payment is held until released.")]
    Hold = CILPaymentTypeCode.Hold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pays on same day as convert/exercise instructions.
    /// Encoded/decoded by serializers as "PCIL".
    /// </summary>
    [EnumMember(Value = "PCIL")]
    [IsoId("_1tJmAjL3EeKU9IrkkToqcw_-43100213")]
    [Description(@"Pays on same day as convert/exercise instructions.")]
    PayCIL = CILPaymentTypeCode.PayCIL, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CILPaymentType1CodeMetadataExtensions
{
    private static readonly CILPaymentType1CodeDropdownSource _dropdownSource = new CILPaymentType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICILPaymentType1CodeDropdownRow GetMetadata(this CILPaymentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


