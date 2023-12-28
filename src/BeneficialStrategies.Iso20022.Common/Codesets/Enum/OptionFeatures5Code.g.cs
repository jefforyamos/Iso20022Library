﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionFeatures5Code.  ISO2002 ID# _R2efACdaEeOXAt_43VmZGw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_R2efACdaEeOXAt_43VmZGw")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
public enum OptionFeatures5Code
{
    /// <summary>
    /// Option is offered by the account servicer only.
    /// Encoded/decoded by serializers as "AccountServicerOption".
    /// </summary>
    [EnumMember(Value = "ASVO")]
    [IsoId("_zjcv8SdaEeOXAt_43VmZGw")]
    [Description(@"Option is offered by the account servicer only.")]
    AccountServicerOption,
    
    /// <summary>
    /// Indicates that the holder needs to instruct at beneficiary owner level only.
    /// Encoded/decoded by serializers as "BeneficiaryOwnerInstruction".
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_zp_c0SdaEeOXAt_43VmZGw")]
    [Description(@"Indicates that the holder needs to instruct at beneficiary owner level only.")]
    BeneficiaryOwnerInstruction,
    
    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as "Conditional".
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_zvMs8SdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the holder can elect to place a condition on the acceptance of the option.")]
    Conditional,
    
    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as "MaximumCash".
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_z1mP4SdaEeOXAt_43VmZGw")]
    [Description(@"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.")]
    MaximumCash,
    
    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as "MaximumSecurities".
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_z6NqISdaEeOXAt_43VmZGw")]
    [Description(@"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.")]
    MaximumSecurities,
    
    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).
    /// Encoded/decoded by serializers as "NoServiceOffered".
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("_z-hiYSdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).")]
    NoServiceOffered,
    
    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as "OddLotPreference".
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_0DSGkSdaEeOXAt_43VmZGw")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference,
    
    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as "OptionApplicability".
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("_0Jh4gSdaEeOXAt_43VmZGw")]
    [Description(@"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.")]
    OptionApplicability,
    
    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.
    /// Encoded/decoded by serializers as "OverAndAbove".
    /// </summary>
    [EnumMember(Value = "QOVE")]
    [IsoId("_0QYHYSdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.")]
    OverAndAbove,
    
    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as "PreviousInstructionInvalidity".
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_0WCDcSdaEeOXAt_43VmZGw")]
    [Description(@"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.")]
    PreviousInstructionInvalidity,
    
    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive.
    /// Encoded/decoded by serializers as "QuantityToReceive".
    /// </summary>
    [EnumMember(Value = "QREC")]
    [IsoId("_0aV7sSdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the holder can elect a quantity to receive.")]
    QuantityToReceive,
    
    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as "Proration".
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_0iE7YSdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.")]
    Proration,
    
    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as "ReducedWithholdingTax".
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_0oeeUSdaEeOXAt_43VmZGw")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionFeatures5CodeMetadataExtensions
{
    private static readonly OptionFeatures5CodeDropdownSource _dropdownSource = new OptionFeatures5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionFeatures5CodeDropdownRow GetMetadata(this OptionFeatures5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


