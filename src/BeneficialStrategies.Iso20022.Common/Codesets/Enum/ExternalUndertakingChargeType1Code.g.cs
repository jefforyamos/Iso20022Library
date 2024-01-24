﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUndertakingChargeType1Code.  ISO2002 ID# _-MhZBG7iEeKo25nLKvGr8w_-389480050.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external charge type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MhZBG7iEeKo25nLKvGr8w_-389480050")]
[Description(@"Specifies the external charge type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUndertakingChargeTypeCode))]
public enum ExternalUndertakingChargeType1Code
{
    /// <summary>
    /// Charge related to the issuance of an amendment.
    /// Encoded/decoded by serializers as "AMND".
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_uQ7a9fRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the issuance of an amendment.")]
    Amendment = ExternalUndertakingChargeTypeCode.Amendment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge related to the processing of a claim.
    /// Encoded/decoded by serializers as "CLAM".
    /// </summary>
    [EnumMember(Value = "CLAM")]
    [IsoId("_uQ7a-PRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the processing of a claim.")]
    Claim = ExternalUndertakingChargeTypeCode.Claim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission charge.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uQ7a-_RYEeuLhpyIdtJzwg")]
    [Description(@"Commission charge.")]
    Commission = ExternalUndertakingChargeTypeCode.Commission, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge for confirmation.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uREk4vRYEeuLhpyIdtJzwg")]
    [Description(@"Charge for confirmation.")]
    Confirmation = ExternalUndertakingChargeTypeCode.Confirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Courier charge.
    /// Encoded/decoded by serializers as "COUR".
    /// </summary>
    [EnumMember(Value = "COUR")]
    [IsoId("_uREk5fRYEeuLhpyIdtJzwg")]
    [Description(@"Courier charge.")]
    Courier = ExternalUndertakingChargeTypeCode.Courier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge related to the issuance of an undertaking.
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_uROV4vRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the issuance of an undertaking.")]
    IssuanceCharge = ExternalUndertakingChargeTypeCode.IssuanceCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Miscellaneous charge.
    /// Encoded/decoded by serializers as "MISC".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_uROV5fRYEeuLhpyIdtJzwg")]
    [Description(@"Miscellaneous charge.")]
    Miscellaneous = ExternalUndertakingChargeTypeCode.Miscellaneous, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge related to the payment processing.
    /// Encoded/decoded by serializers as "PAYM".
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_uROV6PRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the payment processing.")]
    Payment = ExternalUndertakingChargeTypeCode.Payment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Postage charge.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_uROV6_RYEeuLhpyIdtJzwg")]
    [Description(@"Postage charge.")]
    Postage = ExternalUndertakingChargeTypeCode.Postage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Telecommunication charge.
    /// Encoded/decoded by serializers as "TELE".
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_uROV7vRYEeuLhpyIdtJzwg")]
    [Description(@"Telecommunication charge.")]
    Telecommunication = ExternalUndertakingChargeTypeCode.Telecommunication, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUndertakingChargeType1CodeMetadataExtensions
{
    private static readonly ExternalUndertakingChargeType1CodeDropdownSource _dropdownSource = new ExternalUndertakingChargeType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUndertakingChargeType1CodeDropdownRow GetMetadata(this ExternalUndertakingChargeType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


